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
    }
}
