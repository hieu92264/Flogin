using System.Security.Cryptography;

namespace Flogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrEmpty(txt_pass.Text))
                {
                    errorProvider.SetError(txt_pass, "Bạn chưa nhập Pass");

                    errorProvider.SetError(txt_name, "Bạn chưa nhập Tên");
                    txt_name.Focus();
                }
                else if (string.IsNullOrEmpty(txt_pass.Text))
                {
                    errorProvider.SetError(txt_pass, "Bạn chưa nhập Pass");
                    txt_pass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txt_name.Text == "admin" && txt_pass.Text == "12345")
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    FormMain frm = new FormMain();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    txt_name.Focus();
                }
            }

        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) Application.Exit();
        }
    }
}