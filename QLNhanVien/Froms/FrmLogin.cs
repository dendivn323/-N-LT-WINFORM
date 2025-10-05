using QLNhanVien.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanVien
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //lấy ra user và pass người dùng nhập
            string UserName = txtUserName.Text;
            string Pass = txtPassword.Text;
            //Xử lý lưu pass
            if (ckcSavePass.Checked == true)
            {
                Properties.Settings.Default.UserName = UserName;
                Properties.Settings.Default.PassWord = Pass;
                Properties.Settings.Default.SavePass = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.SavePass = false;
                Properties.Settings.Default.Save();
            }

            //Giả sử user = "hieu" pass = "123" là đúng ( xử lý với DB)
            if (UserName == "hieu" && Pass == "123")
            {

                
                MessageBox.Show("Đăng nhập thành công");
                //show form Dialog
                this.Visible = false;
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                //code này sẽ chạy show khi đóng form dialog
                this.Visible = true;
            }
            else { MessageBox.Show("Sai thông tin đăng nhập");}
        }

        private void ckcShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void ckcSavePass_CheckedChanged(object sender, EventArgs e)
        {
            //Xử lý lưu vào App.config

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
            //SỬA CODE CỦA HIẾU
            //Lấy ra user pass 
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.PassWord;
            ckcSavePass.Checked = Properties.Settings.Default.SavePass;

        }
    }
}
