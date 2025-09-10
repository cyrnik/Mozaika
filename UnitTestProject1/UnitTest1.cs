using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string connect = "Data Source=desktop-hfuigkr;Initial Catalog=Bikina;Integrated Security=True;Encrypt=False";

        [TestMethod]
        public void TestMethod1()
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                string username = "manager_ivanov";
                string query = "SELECT [РОЛЬ] FROM [ПОЛЬЗОВАТЕЛИ_ВХОД] WHERE [ЛОГИН] = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["РОЛЬ"].ToString();
                            Assert.AreEqual("Менеджер", role);
                        }
                        else
                        {
                            Assert.Fail("Пользователь не найден");
                        }
                    }
                }
            }
        }

            [TestMethod]
            public void TestMethod_CorrectLogin_ReturnsManagerRole()
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string username = "manager_ivanov";
                    string query = "SELECT [РОЛЬ] FROM [ПОЛЬЗОВАТЕЛИ_ВХОД] WHERE [ЛОГИН] = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["РОЛЬ"].ToString();
                                Assert.AreEqual("Менеджер", role);
                            }
                            else
                            {
                                Assert.Fail("Пользователь не найден");
                            }
                        }
                    }
                }
            }

            [TestMethod]
            public void TestMethod_IncorrectLogin_UserNotFound()
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string username = "nonexistent_user";
                    string query = "SELECT [РОЛЬ] FROM [ПОЛЬЗОВАТЕЛИ_ВХОД] WHERE [ЛОГИН] = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Ожидаем, что пользователь не будет найден
                            bool userExists = reader.Read();
                            Assert.IsFalse(userExists, "Несуществующий пользователь не должен быть найден в базе");
                        }
                    }
                }
            }

        }
    }