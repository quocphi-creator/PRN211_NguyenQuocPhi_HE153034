using Phi_AssignmentPRN.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phi_AssignmentPRN.DAL
{
    class MemberDAO
    {
        public static List<Member> GetAllMember()
        {
            string sql = @"SELECT [MemberID]
                            ,[MemberName]
                            ,[Email]
                            ,[Password]
                            ,[City]
                            ,[Country]
                            FROM [dbo].[Member]";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Member> members = new List<Member>();

            foreach (DataRow dr in dt.Rows)
            {
                members.Add(new Member(
                    Convert.ToInt32(dr["MemberID"]),
                    dr["MemberName"].ToString(),
                    dr["Email"].ToString(),
                    dr["Password"].ToString(),
                    dr["City"].ToString(),
                    dr["Country"].ToString()
                    ));
            }
            return members;
        }

        public static Member GetMemberByID(int MemberID)
        {
            string sql = @"SELECT [MemberID]
                            ,[MemberName]
                            ,[Email]
                            ,[Password]
                            ,[City]
                            ,[Country]
                        FROM [dbo].[Member]
                        WHERE [MemberID] = @mid";

            SqlParameter parameter1 = new SqlParameter("@mid", DbType.Int32);
            parameter1.Value = MemberID;

            DataTable dt = DAO.GetDataBySql(sql, parameter1);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            DataRow dr = dt.Rows[0];
            return new Member(
                    Convert.ToInt32(dr["MemberID"]),
                    dr["MemberName"].ToString(),
                    dr["Email"].ToString(),
                    dr["Password"].ToString(),
                    dr["City"].ToString(),
                    dr["Country"].ToString()
                    );
        }

        public static int DeleteMember(int MemberID)
        {
            string sql = @"DELETE FROM [dbo].[Member]
                            WHERE [MemberID] = @mid";
            SqlParameter parameter1 = new SqlParameter("@mid", DbType.Int32);
            parameter1.Value = MemberID;
            return DAO.ExecuteSql(sql, parameter1);
        }

        public static int UpdateStudent(int MemberID, string MemberName, string Email, string Password, string City, string Country)
        {
            string sql = @"UPDATE [dbo].[Member]
                        SET [MemberName] = @name
                            ,[Email] = @email
                            ,[Password] = @pass
                            ,[City] = @city
                            ,[Country] = @country
                        WHERE [MemberID] = @id";

            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter("@id", DbType.Int32);
            parameters[0].Value = MemberID;

            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[1].Value = MemberName;

            parameters[2] = new SqlParameter("@email", SqlDbType.NChar);
            parameters[2].Value = Email;

            parameters[3] = new SqlParameter("@pass", SqlDbType.NChar);
            parameters[3].Value = Password;

            parameters[4] = new SqlParameter("@city", SqlDbType.NVarChar);
            parameters[4].Value = City;

            parameters[5] = new SqlParameter("@country", SqlDbType.NVarChar);
            parameters[5].Value = Country;

            return DAO.ExecuteSql(sql, parameters);
        }

        public static int InsertStudent(string MemberName, string Email, string Password, string City, string Country)
        {
            string sql = @"INSERT INTO [dbo].[Member]
                            ([MemberName]
                            ,[Email]
                            ,[Password]
                            ,[City]
                            ,[Country])
                        VALUES
                            (@name
                            ,@email
                            ,@pass
                            ,@city
                            ,@country)";

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            parameters[0].Value = MemberName;

            parameters[1] = new SqlParameter("@email", SqlDbType.NChar);
            parameters[1].Value = Email;

            parameters[2] = new SqlParameter("@pass", SqlDbType.NChar);
            parameters[2].Value = Password;

            parameters[3] = new SqlParameter("@city", SqlDbType.NVarChar);
            parameters[3].Value = City;

            parameters[4] = new SqlParameter("@country", SqlDbType.NVarChar);
            parameters[4].Value = Country;

            return DAO.ExecuteSql(sql, parameters);
        }
    }
}
