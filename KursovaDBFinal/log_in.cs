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

namespace KursovaDBFinal
{
    public partial class log_in : Form
    {
        DataBase database = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            pictureBox_eye22.Visible = false;
            textBox_log2.MaxLength = 50;
            textBox_pass2.MaxLength = 50;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }

        private void BtnEnter_Click_1(object sender, EventArgs e)
        {
            var loginUser = textBox_log2.Text;
            var passUser = textBox_pass2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void pictureBox_eye22_Click(object sender, EventArgs e)
        {
            textBox_pass2.UseSystemPasswordChar = false;
            pictureBox_eye22.Visible = false;
            pictureBox_eye21.Visible = true;
        }
        private void pictureBox_eye21_Click(object sender, EventArgs e)
        {
            textBox_pass2.UseSystemPasswordChar = true;
            pictureBox_eye22.Visible = true;
            pictureBox_eye21.Visible = false;
        }
    }
}
