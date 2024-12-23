using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToothCare_Hub.MainFiles;

namespace ToothCare_Hub
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

        // 2. Проверка БД на наличие записей
        public Boolean isFirstUser()
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

        // 4. Проверка БД на дубликат логина
        public Boolean isUserExist()
        {
            string query = "SELECT * FROM `users` WHERE `nick` = @Login";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такий логін вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }
        public Boolean isEmailExist()
        {
            string query = "SELECT * FROM `users` WHERE `mail` = @Email";
            using (MySqlCommand command = new MySqlCommand(query, database.getConnection()))
            {
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = Email;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такая почта существует", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                else
                    return false;
            }
        }




        public Boolean checkLoginAndPassword()
        {
            if (this.Login == this.Password)
            {
                MessageBox.Show("Паролм і логін не повинні збігатися", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;
        }

        public Boolean checkPassword()
        {
            if (this.Password != this.RepeatPassword)
            {
                MessageBox.Show("Паролі не співпадають", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
                return false;

        }
    }
}
