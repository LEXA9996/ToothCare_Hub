using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToothCare_Hub
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            //Text
            NameField.Text = "Введите имя";
            SurnameField.Text = "Введите фамилию";
            NickField.Text = "Придумайте свой логин";
            MailField.Text = "Введите свою электронную почту";
            PassField.Text = "Придумайте пароль";
            CopyPassField.Text = "Повторите пароль";
            //color
            NameField.ForeColor = Color.FromArgb(128, 128, 128);
            SurnameField.ForeColor = Color.FromArgb(128, 128, 128);
            NickField.ForeColor = Color.FromArgb(128, 128, 128);
            MailField.ForeColor = Color.FromArgb(128, 128, 128);
            PassField.ForeColor = Color.FromArgb(128, 128, 128);
            CopyPassField.ForeColor = Color.FromArgb(128, 128, 128);


        }

        private void CloseRegisterForm_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //move panel
        Point lastPoint;

        private void CloseAndMoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseAndMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //close panel
        private void CloseRegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            CloseRegisterForm.BackColor = Color.FromArgb(255, 0, 0);
            CloseRegisterForm.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void CloseRegisterForm_MouseLeave(object sender, EventArgs e)
        {

            CloseRegisterForm.BackColor = Color.FromArgb(164, 185, 255);
            CloseRegisterForm.ForeColor = Color.FromArgb(0, 0, 0);

        }




        //Input information
        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void MailField_Enter(object sender, EventArgs e)
        {
            if (MailField.Text == "Введите свою электронную почту")
            {
                MailField.Text = "";
                MailField.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void NickField_Enter(object sender, EventArgs e)
        {
            if (NickField.Text == "Придумайте свой логин")
            {
                NickField.Text = "";
                NickField.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void PassField_MouseEnter(object sender, EventArgs e)
        {
            if (PassField.Text == "Придумайте пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }

        private void CopyPassField_Enter(object sender, EventArgs e)
        {
            if (CopyPassField.Text == "Повторите пароль")
            {
                CopyPassField.Text = "";
                CopyPassField.ForeColor = Color.FromArgb(0, 0, 0);
                CopyPassField.PasswordChar = '*';
            }
        }

        //Delete information
        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Введите фамилию";
                SurnameField.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void MailField_Leave(object sender, EventArgs e)
        {
            if (MailField.Text == "")
            {
                MailField.Text = "Введите свою электронную почту";
                MailField.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void NickField_Leave(object sender, EventArgs e)
        {
            if (NickField.Text == "")
            {
                NickField.Text = "Придумайте свой логин";
                NickField.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void PassField_Leave(object sender, EventArgs e)
        {
            if (PassField.Text == "")
            {
                PassField.Text = "Придумайте пароль";
                PassField.ForeColor = Color.FromArgb(128, 128, 128);
                PassField.PasswordChar = '\0';
            }
        }

        private void CopyPassField_Leave(object sender, EventArgs e)
        {
            if (CopyPassField.Text == "")
            {
                CopyPassField.Text = "Повторите пароль";
                CopyPassField.ForeColor = Color.FromArgb(128, 128, 128);
                CopyPassField.PasswordChar = '\0';
            }
        }
        //input password 
        private void PassField_Enter(object sender, EventArgs e)
        {
            if (PassField.Text == "Придумайте пароль")
            {
                PassField.Text = "";
                PassField.ForeColor = Color.FromArgb(0, 0, 0);
                PassField.PasswordChar = '*';
            }
        }
        //go over login Form
        private void HideLoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            HideLoginLabel.ForeColor = Color.FromArgb(14, 21, 181);
        }

        private void HideLoginLabel_MouseLeave(object sender, EventArgs e)
        {
            HideLoginLabel.ForeColor = Color.FromArgb(0,0,0);
        }
        
    }
}
