using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Npgsql;

namespace CRM_Pyaterochka
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;" + "Password=admin;Database=CRM_Pyaterochka;");
        public Form1()
        {
            InitializeComponent();
            
            conn.Open(); 
            NpgsqlDataReader dr = new NpgsqlCommand("select * from \"Pyaterochka\".goods", conn).ExecuteReader();
            while (dr.Read())
            {
                
            }
            conn.Close();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}