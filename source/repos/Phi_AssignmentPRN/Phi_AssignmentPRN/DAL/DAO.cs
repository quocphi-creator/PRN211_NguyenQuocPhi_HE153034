using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phi_AssignmentPRN.DAL
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionStr = "server=DESKTOP-01NQ3KO;database=AssignmentPrn211;user=SE1616;password=22012001;";
            return new SqlConnection(ConnectionStr);
        }

        
        public static DataTable GetDataBySql(string sql, params SqlParameter[] parageters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());

            if(parageters != null || parageters.Length == 0)
            {
                command.Parameters.AddRange(parageters);
            }
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        public static int ExecuteSql(string sql, params SqlParameter[] parageters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parageters != null || parageters.Length == 0)
            {
                command.Parameters.AddRange(parageters);
            }
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
    }
}
