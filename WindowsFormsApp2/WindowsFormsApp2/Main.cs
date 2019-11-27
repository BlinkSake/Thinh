using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect(); //Đóng kết nối
            Application.Exit(); //Thoát
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials category = new Materials();
            category.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }

        private void billOfSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.ShowDialog();
        }
    }
}
