using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sql_data_base
{
    public partial class Mainfile : Form
    {
        DataBaseConnect conn;
        public Mainfile()
        {
            InitializeComponent();
            conn = new DataBaseConnect();
            conn.OpenConnect();
        }

        private void select_check_Click(object sender, EventArgs e)
        {
            
            string QuerySelectCheck = $"Select [name],[password] from mytable where [name] = '{loginG1_text.Text}'and [password] ='{passwordG1_text.Text}'";
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand command = new SqlCommand(QuerySelectCheck, conn.GetConnection());
                DataTable dt = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("success", "select check");
                }
                else 
                {
                    MessageBox.Show("not success", "select check");
                }
            }
            
        }

        private void insert_into_Click(object sender, EventArgs e)
        {
            string Queryinsertinto = $"insert into  mytable([name],[password])values('{loginG2_text.Text}','{passwordG2_text.Text}')";
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand command = new SqlCommand(Queryinsertinto, conn.GetConnection());
                DataTable dt = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                  MessageBox.Show("success", "insert into");
            }
        }

        private void select_show_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string QuerySelectShow = "Select * from mytable";
            using (SqlCommand command = new SqlCommand(QuerySelectShow,conn.GetConnection())) 
            {
                using (SqlDataReader read= command.ExecuteReader()) 
                {
                   
                    while (read.Read()) 
                        listBox1.Items.Add($"id={read[0]}, name = {read[1]}, password = {read[2]}");
                       
                    
                }
            }

        }

        private void Mainfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.CloseConnect();
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            string Querydelete = $"delete from mytable where [name] = '{loginG3_text.Text}'and [password] ='{passwordG3_text.Text}'";
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                SqlCommand command = new SqlCommand(Querydelete, conn.GetConnection());
                command.ExecuteNonQuery();
                
     
            }
          
        }
    }
}
