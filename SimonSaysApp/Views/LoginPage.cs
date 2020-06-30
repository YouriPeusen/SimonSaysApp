using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonSaysApp.Views
{
	public partial class LoginPage : Form
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		public void Login()
		{
			this.Hide();
			MainPage form = new MainPage();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			Login();
		}
	}
}
