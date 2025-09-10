using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikina
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=desktop-hfuigkr;Initial Catalog=Bikina;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Проверка введенных данных
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка пользователя в базе данных
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT РОЛЬ, ПАРОЛЬ FROM ПОЛЬЗОВАТЕЛИ_ВХОД WHERE ЛОГИН = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string dbPassword = reader["ПАРОЛЬ"].ToString();
                                string role = reader["РОЛЬ"].ToString();

                                // Проверка пароля
                                if (dbPassword == password)
                                {
                                    OpenFormByRole(role);
                                }
                                else
                                {
                                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка базы данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFormByRole(string role)
        {
            Form formToOpen = null;

            switch (role)
            {
                case "Менеджер":
                    formToOpen = new Form2();
                    break;
                case "Партнер":
                    formToOpen = new Form3();
                    break;
                case "Кадры":
                    formToOpen = new Form4();
                    break;
                case "Склад":
                    formToOpen = new Form5();
                    break;
                default:
                    MessageBox.Show("Неизвестная роль пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Скрываем текущую форму и открываем новую
            this.Hide();
            formToOpen.Closed += (s, args) => this.Close();
            formToOpen.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        // Обработка нажатия клавиши Enter в поле пароля
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void дОСТУПBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.дОСТУПBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bikinaDataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ПОСТАВКА". При необходимости она может быть перемещена или удалена.
            this.пОСТАВКАTableAdapter.Fill(this.bikinaDataSet.ПОСТАВКА);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.МЕНЕДЖЕРЫ". При необходимости она может быть перемещена или удалена.
            this.мЕНЕДЖЕРЫTableAdapter.Fill(this.bikinaDataSet.МЕНЕДЖЕРЫ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bikinaDataSet.ДОСТУП". При необходимости она может быть перемещена или удалена.
            this.дОСТУПTableAdapter.Fill(this.bikinaDataSet.ДОСТУП);

        }
    }
}