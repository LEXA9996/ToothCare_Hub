using MySql.Data.MySqlClient;
using System.Data;

namespace ToothCare_Hub.MainFiles.Checking.password
{
    public class Verification
    {
        private string Login;
        private string Password;
        private string RepeatPassword;
        private string Email;
        private DB database = new DB();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();



        public Verification(string Login, string Password, string RepeatPassword, string Email)
        {
            this.Login = Login;
            this.Password = Password;
            this.RepeatPassword = RepeatPassword;
            this.Email = Email;
        }

        public Verification(string Password, string RepeatPassword, string Email)
        {
            this.Password = Password;
            this.RepeatPassword = RepeatPassword;
            this.Email = Email;
        }

        //
        #region/Check_Sql
        // 2. Проверка БД на наличие записей
        public bool isFirstUser()
        {
            string query = "SELECT COUNT(*) FROM users";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                database.openConnection();
                int userCount = Convert.ToInt32(command.ExecuteScalar());
                database.closeConnection();

                if (userCount == 0)
                {
                    MessageBox.Show("Вітаємо ви перший користувач, що зареєструвався.\n" +
                        " Вам було видано права адміністратора.\n" +
                        " Будь ласка, використовуйте клієнт для адміністраторів, оскільки цей клієнт не " +
                        "має підтримки панелі адміністрації.", "Повідомленя",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                    return false;
            }
        }
        #endregion
        // 4. Проверка БД на дубликат логина
        public bool isUserExist()
        {
            string query = "SELECT * FROM `users` WHERE `nick` = @Login";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такой логин уже существует.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                    return false;
            }
        }
        public bool isEmailExist()
        {
            string query = "SELECT * FROM `users` WHERE `mail` = @Email";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такая почта уже существует", "Предупеждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                else
                    return false;
            }
        }




        public bool checkLoginAndPassword()
        {
            if (Login == Password)
            {
                MessageBox.Show("Пароль и логин не должны совпадать", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;
        }

        public bool checkPassword()
        {
            if (Password != RepeatPassword)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
                return false;

        }
    }
}
