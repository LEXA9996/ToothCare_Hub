using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToothCare_Hub.MainFiles;

namespace ToothCare_Hub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //Text
            LoginInput.Text = "Введите свой логин или почту";
            PasswordInput.Text = "Введите свой пароль";
            //color
            LoginInput.ForeColor = Color.FromArgb(128, 128, 128);
            PasswordInput.ForeColor = Color.FromArgb(128, 128, 128);

        }



        private void CloseAuthorization_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;

        //move form

        private void LoginCloseAndMovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginCloseAndMovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //close form
        private void CloseAuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            CloseAuthorization.BackColor = Color.FromArgb(255, 0, 0);
            CloseAuthorization.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void CloseAuthorization_MouseLeave(object sender, EventArgs e)
        {
            CloseAuthorization.BackColor = Color.FromArgb(164, 185, 255);
            CloseAuthorization.ForeColor = Color.FromArgb(0, 0, 0);
        }
        //unput information
        private void LoginInput_Enter(object sender, EventArgs e)
        {
            if (LoginInput.Text == "Введите свой логин или почту")
            {
                LoginInput.Text = "";
                LoginInput.ForeColor = Color.FromArgb(0, 0, 0);
            }

        }

        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "Введите свой пароль")
            {
                PasswordInput.Text = "";
                PasswordInput.ForeColor = Color.FromArgb(0, 0, 0);
                PasswordInput.PasswordChar = '*';
            }
        }
        //delete information
        private void LoginInput_Leave(object sender, EventArgs e)
        {
            if (LoginInput.Text == "")
            {
                LoginInput.Text = "Введите свой логин или почту";
                LoginInput.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void PasswordInput_Leave(object sender, EventArgs e)
        {
            if (PasswordInput.Text == "")
            {
                PasswordInput.Text = "Введите свой пароль";
                PasswordInput.ForeColor = Color.FromArgb(128, 128, 128);
                PasswordInput.PasswordChar = '\0';
            }
        }
        #region label click
        // label click
        private void RegisterAcc_MouseLeave(object sender, EventArgs e)
        {
            RegisterAcc.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RegisterAcc_MouseMove(object sender, MouseEventArgs e)
        {
            RegisterAcc.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ForgotPassword_MouseMove(object sender, MouseEventArgs e)
        {
            ForgotPassword.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            ForgotPassword.ForeColor = Color.FromArgb(0, 0, 0);
        }
        #endregion
        private void RegisterAcc_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            lastPoint = this.Location;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = lastPoint;
        }

        private void EnterAccount_Click(object sender, EventArgs e)
        {
            var db = new MainFiles.Checking.DB();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();
            var hashing = new MainFiles.Checking.password.Hashing();
            String loginUser = LoginInput.Text;
            String passwordUser = PasswordInput.Text;
            var command = new MySqlCommand("SELECT * FROM `users` WHERE `nick` = @input OR `mail` = @input AND `password` = @pass", db.getConnection());
            command.Parameters.Add("@input", MySqlDbType.VarChar).Value = loginUser;
            var HashPassword = hashing.Hash(passwordUser);
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = HashPassword;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                string storedHashedPassword = table.Rows[0]["password"].ToString();

                if (hashing.Verify(passwordUser, storedHashedPassword))
                {
                    MessageBox.Show("Успешный вход");
                }
                else
                {
                    MessageBox.Show("Неверный пароль!");
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
        }

    }
}
