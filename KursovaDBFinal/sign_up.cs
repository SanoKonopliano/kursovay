using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace KursovaDBFinal
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var login = textBox_log1.Text;
            var password = textBox_pass1.Text;
            if (checkuser())
            {
                return;
            }

            string querystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());


            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else { MessageBox.Show("Аккаунт не может быть зарегистрирован!", "Аккаунт уже зарегистрирован!"); }
            dataBase.closeConnection();
            
        }
        private Boolean checkuser()
        {
            var loginUser = textBox_log1.Text;
            var passUser = textBox_pass1.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой аккаунт уже зарегистрирован");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
