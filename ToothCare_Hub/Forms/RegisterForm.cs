using MySql.Data.MySqlClient;
using ToothCare_Hub.MainFiles;

namespace ToothCare_Hub
{
    public partial class RegisterForm : Form
    {
        Verification verification;
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
            this.StartPosition = FormStartPosition.CenterScreen;


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



        #region Input information / Delete information
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

        #endregion

        //go over login Form
        private void HideLoginLabel_MouseMove(object sender, MouseEventArgs e)
        {
            HideLoginLabel.ForeColor = Color.FromArgb(14, 21, 181);
        }

        private void HideLoginLabel_MouseLeave(object sender, EventArgs e)
        {
            HideLoginLabel.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void HideLoginLabel_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
            lastPoint = this.Location;
            loginform.StartPosition = FormStartPosition.Manual;
            loginform.Location = lastPoint;
        }
        #region/error
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя"
                || SurnameField.Text == "Введите фамилию"
                || MailField.Text == "Введите свою электронную почту"
                || NickField.Text == "Придумайте свой логин"
                || PassField.Text == "Придумайте пароль"
                || CopyPassField.Text == "Повторите пароль")
            {
                MessageBox.Show("Вы указали не все данные.", "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            verification = new Verification(NickField.Text, 
                PassField.Text, CopyPassField.Text, MailField.Text);

            if (verification.checkLoginAndPassword())
                return;
            if (verification.checkPassword())
                return;
            if (verification.isUserExist())
                return;
            if (verification.isEmailExist())
                return;
            #endregion

            DB db = new DB();
            Hashing hashing = new Hashing();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `surname`, `nick`, `mail`, `password`) VALUES (@name, @surname, @nick, @mail, @pass);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameField.Text;
            command.Parameters.Add("@nick", MySqlDbType.VarChar).Value = NickField.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = MailField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = hashing.Hash(CopyPassField.Text);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегестрировались! Ввойдите теперь свой аккаунт", "Операция прошла успешно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                loginForm.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                MessageBox.Show("Вы не смогли зарегестироваться, попробуйте ещё раз", "Произошла ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.closeConnection();

        }

    }
}
