using Phi_AssignmentPRN.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phi_AssignmentPRN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MemberDAO.GetAllMember();
            LoadDataForDGV();
        }

        private void LoadDataForDGV()
        {
            dataGridView1.DataSource = MemberDAO.GetAllMember();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int MemberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            
            DialogResult result = MessageBox.Show($"Bạn có thực sự muốn xóa member có mã {MemberID}?", "Xác nhận", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                MemberDAO.DeleteMember(MemberID);
                LoadDataForDGV();
            }
            
        }

        private void lablelSearch_Click(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(string.Empty))
            {
                MessageBox.Show("Nhập thông tin sinh viên mới để thêm");
                return;
            }
            int k = MemberDAO.InsertStudent(
                txtName.Text,
                txtPass.Text,
                txtEmail.Text,
                txtCity.Text,
                txtCountry.Text
            );

            if(k != 1)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm member, vui lòng thử lại");
            }
            LoadDataForDGV();
        }

        //private void btEdit_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Bạn thực sự có muốn cập nhật dữ liệu của member?", "Xác Nhận", MessageBoxButtons.YesNo);
        //    if (result == DialogResult.Yes)
        //    {
        //        MemberDAO.UpdateStudent(
        //            txtName.Text,
        //            txtPass.Text,
        //            txtEmail.Text,
        //            txtCity.Text,
        //            txtCountry.Text);
                    
        //    }
        //}
      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPass.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtCity.Text = row.Cells[4].Value.ToString();
            txtCountry.Text = row.Cells[5].Value.ToString();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(string.Empty)){
                MessageBox.Show("Dữ liệu trống, vui lòng chọn dữ liệu để cập nhật.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                int k = MemberDAO.UpdateStudent(
                    Convert.ToInt32(txtId.Text),
                    txtName.Text,
                    txtPass.Text,
                    txtEmail.Text,
                    txtCity.Text,
                    txtCountry.Text
                );
                if(k!=1)
                {
                    MessageBox.Show("Đã xảy ra lỗi, chưa thể cập nhật.");
                }
            }
            LoadDataForDGV();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

    }
}
