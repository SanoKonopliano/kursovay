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

namespace KursovaDBFinal
{
    public partial class Add_Form : Form
    {

        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var type = textBox_typeTrack.Text;
            var speed = textBox_speed.Text;
            int length;
            var stops = textBox_stops.Text;
            var city = textBox_city.Text;
            var population = textBox_population.Text;
            var number = textBox_numTrack.Text;
            

            if(int.TryParse(textBox_length.Text, out  length))
            {
                var addQuery = $"insert into Track (type_of, num_track, distance, count_atnt, count_of, city, population) values ('{type}', '{number}', '{length}', '{speed}', '{stops}', '{city}', '{population}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();


        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
