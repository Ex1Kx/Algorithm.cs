using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JLCRUDPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chargetable(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            chargetable(date);
        }
        private void chargetable(string date)
        {
            List<Persons> list = new List<Persons>();
            Controller _ctrPersons = new Controller();
            dataGridView1.DataSource = _ctrPersons.query(date);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Persons _persons = new Persons();
            _persons.Prnames = textBox2.Text;

            Controller ctrl = new Controller();

            if(textBox3.Text != "")
            {
                _persons.Id = int.Parse(textBox3.Text);
               flag = ctrl.update(_persons);
            }
            else
            {
                flag = ctrl.insert(_persons);
            }
            if(flag)
            {
                MessageBox.Show("Guardado");
                clean();
                chargetable(null);
            }
        }
        private void clean()
        {
            textBox3.Text = "";
            textBox2.Text = "";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Controller _ctrl = new Controller();
                _ctrl.delete(id);
                chargetable(null);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
