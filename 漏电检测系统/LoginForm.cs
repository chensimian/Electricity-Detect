using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 漏电检测系统
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            if(TEXT_UserName.Text=="wyu"&&TEXT_Password.Text=="123456")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("输出错误");
            }
        }

		private void TEXT_UserName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
