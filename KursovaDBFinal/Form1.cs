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
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {

        DataBase database = new DataBase();

        int selectedRow;


        public Form1()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView.Columns.Add("id", "id");
            dataGridView.Columns.Add("type_of", "Тип дороги");
            dataGridView.Columns.Add("count_of", "Кол-во мостов");
            dataGridView.Columns.Add("distance", "Дистанция");
            dataGridView.Columns.Add("count_of_atnt", "Кол-во препятствий");
            dataGridView.Columns.Add("num_track", "Номер дороги");
            dataGridView.Columns.Add("city", "Города");
            dataGridView.Columns.Add("population", "Население");
            dataGridView.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRoW(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetInt32(3), 
                record.GetInt32(4), record.GetString(5), record.GetString(6), RoWState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Track";
            

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRoW(dgw, reader);      
            }
            reader.Close();


            database.closeConnection();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView);

        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_Cities.Text = row.Cells[1].Value.ToString();
                textBox_countPop.Text = row.Cells[2].Value.ToString();
                textBox_numTrack.Text = row.Cells[3].Value.ToString();
                textBox_typeTrack.Text = row.Cells[4].Value.ToString();
                textBox_speed.Text = row.Cells[5].Value.ToString();
                textBox_countBridge.Text = row.Cells[6].Value.ToString();
            } 
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Track where concat (id, type_of, count_of, distance, count_atnt, num_track, city, population) like '%" + textBox_Search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRoW(dgw, read);
            }

            read.Close();
        }

        private void deleteRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;

            dataGridView.Rows[index].Visible = false;
            if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView.Rows[index].Cells[5].Value = RoWState.Deleted;
            }
        }

        private new void Update()
        {


            database.openConnection(); 

            for(int index = 0; index < dataGridView.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView.Rows[index].Cells[6].Value;

                if (rowState == RoWState.Existed)
                {
                    continue;
                }
                if (rowState == RoWState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Track where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }
                if (rowState == RoWState.Modified)
                {
                    var id = dataGridView.Rows[index].Cells[0].Value.ToString();
                    var city = dataGridView.Rows[index].Cells[1].Value.ToString();
                    var popul = dataGridView.Rows[index].Cells[2].Value.ToString();
                    var numTrack = dataGridView.Rows[index].Cells[2].Value.ToString();
                    var type = dataGridView.Rows[index].Cells[1].Value.ToString();
                    var count = dataGridView.Rows[index].Cells[2].Value.ToString();
                    var speed = dataGridView.Rows[index].Cells[3].Value.ToString();
                    var length = dataGridView.Rows[index].Cells[4].Value.ToString();


                    var changeQuery = $"update Track set type_of = '{type}', count_of = '{count}', num_track '{numTrack}'  count_of_atnt '{speed}', distance '{length}', city '{city}', population '{popul}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                        command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }


        private void отдел1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewPost_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView);
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var type = textBox_typeTrack.Text;
            var count = textBox_countBridge;
            var speed = textBox_speed;
            int length;
            var num_track = textBox_numTrack;
            var city = textBox_Cities;
            var popul = textBox_countPop;

            if (dataGridView.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_length.Text, out length))
                {
                    dataGridView.Rows[selectedRowIndex].SetValues(id, type, count, speed, length, num_track, city, popul);
                    dataGridView.Rows[selectedRowIndex].Cells[5].Value = RoWState.Modified;
                }
                else
                {
                    MessageBox.Show("Длина должна иметь числовой формат!");
                }

            }


        }

        private void городаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
