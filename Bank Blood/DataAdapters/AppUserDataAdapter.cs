using Bank_Blood.BusinessLogicLayer;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bank_Blood.DataAdapters
{
    class AppUserDataAdapter
    {
        #region Private

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connectionStr"].ConnectionString;

        #endregion

        #region Public 

        public DataTable Select()
        {
            var dataTable = new DataTable();

            try
            {
                using (var conn = new SqlConnection(myConnectionString))
                {
                    var sql = @"SELECT * FROM  app_user";
                    var cmd = new SqlCommand(sql, conn);
                    var data = new SqlDataAdapter(cmd);

                    conn.Open();

                    data.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        public bool Insert(AppUser user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                return false;
            }

            var success = false;

            try
            {
                using (var conn = new SqlConnection(myConnectionString))
                {
                    var sql = $@"INSERT INTO app_user
                            VALUES  (@nume_utilizator, @email, @parola, @nume_complet, @telefon, @adresa, @data, @imagine)";

                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nume_utilizator", user.UserName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                    cmd.Parameters.AddWithValue("@nume_complet", user.FullName);
                    cmd.Parameters.AddWithValue("@telefon", user.Contact);
                    cmd.Parameters.AddWithValue("@adresa", user.Address);
                    cmd.Parameters.AddWithValue("@data", user.DataAdded);
                    cmd.Parameters.AddWithValue("@imagine", user.ProfilePicture);

                    conn.Open();

                    var rows = cmd.ExecuteNonQuery();
                    success = rows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return success;
        }

        public bool Update(AppUser user)
        {
            var success = false;

            try
            {
                using (var conn = new SqlConnection(myConnectionString))
                {
                    var sql = @"UPDATE app_user 
                            SET nume_utilizator = @nume_utilizator,
                                email = @email,
                                parola = @parola,
                                nume_complet = @nume_complet,
                                telefon = @telefon,
                                adresa = @adresa,
                                data = @data,
                                imagine = @imagine
                            WHERE user_id = @user_id";

                    var cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nume_utilizator", user.UserName);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@parola", user.Password);
                    cmd.Parameters.AddWithValue("@nume_complet", user.FullName);
                    cmd.Parameters.AddWithValue("@telefon", user.Contact);
                    cmd.Parameters.AddWithValue("@adresa", user.Address);
                    cmd.Parameters.AddWithValue("@data", user.DataAdded);
                    cmd.Parameters.AddWithValue("@imagine", user.ProfilePicture);
                    cmd.Parameters.AddWithValue("@user_id", user.UserId);

                    conn.Open();

                    var rows = cmd.ExecuteNonQuery();
                    success = rows > 0 ? true : false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return success;
        }

        public bool DeleteUser(AppUser user)
        {
            var success = false;

            try
            {
                using (var conn = new SqlConnection(myConnectionString))
                {
                    var sql = @"DELETE FROM app_user WHERE  user_id = @user_id";
                    var cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@user_id", user.UserId);
                    conn.Open();
                    var rows = cmd.ExecuteNonQuery();

                    success = rows > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return success;
        }

        public DataTable Search(string userNameOrId)
        {
            var dataTable = new DataTable();

            try
            {
                using (var conn = new SqlConnection(myConnectionString))
                {
                    var sql = $@"SELECT	*
                                FROM	app_user 
                                WHERE	user_id LIKE '%{userNameOrId}%' 
                                OR		nume_complet LIKE '%{userNameOrId}%' 
                                OR		nume_utilizator LIKE '%{userNameOrId}%'";
                    var cmd = new SqlCommand(sql,conn);
                    var dataAdapter = new SqlDataAdapter(cmd);
                    conn.Open();

                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dataTable;
        }

        #endregion
    }
}
