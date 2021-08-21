using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ContactsConnectionSQL
{
    class ContactsRepository : IContactsRepository
    {
        private string Connectionstring = "Data Source=.;Initial Catalog=contacts;Integrated Security=true";
        /// <summary>
        /// ///////////
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable selectall()
        {
            string query = "Select * From contacts_tb";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }
        /// <summary>
        /// ///////////
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public System.Data.DataTable selectrow(int _ID)
        {
            string query = "Select * From contacts_tb where _ID=" + _ID;
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }
        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="numberphone"></param>
        /// <param name="email"></param>
        /// <param name="age"></param>
        /// <param name="addresss"></param>
        /// <returns></returns>
        public bool insetr(string name, string family, string numberphone, string email, int age, string addresss)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string query = "Insert Into contacts_tb (name,family,numberphone,email,age,addresss) values (@name,@family,@numberphone,@email,@age,@addresss)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@numberphone", numberphone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@addresss", addresss);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {

                return false;
            }

            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// ///////////////
        /// </summary>
        /// <param name="_ID"></param>
        /// <param name="name"></param>
        /// <param name="family"></param>
        /// <param name="numberphone"></param>
        /// <param name="email"></param>
        /// <param name="age"></param>
        /// <param name="addresss"></param>
        /// <returns></returns>
        public bool update(int _ID, string name, string family, string numberphone, string email, int age, string addresss)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string query = "update contacts_tb set name=@name,family=@family,numberphone=@numberphone,email=@email,age=@age,addresss=@addresss where @_ID=_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@family", family);
                command.Parameters.AddWithValue("@numberphone", numberphone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@addresss", addresss);
                command.Parameters.AddWithValue("@_ID", _ID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {
                return false;
            }

            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// /////////////
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public bool delete(int _ID)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            try
            {
                string query = "delete contacts_tb where _ID= @_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@_ID", _ID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }

            catch
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

        }



        public DataTable search(string parameter)
        {
            string query = "Select * From contacts_tb where name like @parameter or family like @parameter";
            SqlConnection Connection = new SqlConnection(Connectionstring);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            Adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }

        public bool ChagePassword(string username, int password)
        {
            SqlConnection connection = new SqlConnection(Connectionstring);
            string query = "update user_tb set username=@username,password=@password";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
