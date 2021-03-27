using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mynotes
{
    public partial class Form1 : Form
    {
        DataTable table;
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_load(object sender,EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("textBox1",typeof(string));
            table.Columns.Add("textBox2", typeof(string));
          

            dataGridView1.DataSource = table;
            dataGridView1.Columns["textBox2"].Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_new(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button_save(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button_read(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index>0) 
            {
                textBox1.Text = table.Rows[index].ItemArray[0].ToString();
                textBox1.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }
        private void button_delete(object sender, EventArgs e)

        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
        
    }
}
