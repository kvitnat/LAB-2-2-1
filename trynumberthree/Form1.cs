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

namespace trynumberthree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet1.categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.myDataSet.categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet1.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.myDataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet1.positions". При необходимости она может быть перемещена или удалена.
            this.positionsTableAdapter.Fill(this.myDataSet.positions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet1.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.myDataSet.employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.holders". При необходимости она может быть перемещена или удалена.
            this.holdersTableAdapter.Fill(this.myDataSet.holders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myDataSet.bakery". При необходимости она может быть перемещена или удалена.
            this.bakeryTableAdapter.Fill(this.myDataSet.bakery);

        }

        //save buttons
        private void buttonSaveBakery_Click(object sender, EventArgs e)
        {
            //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(bakeryTableAdapter);
            this.bakeryTableAdapter.Update(myDataSet.bakery);
        }

        private void buttonEmplSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.Update(myDataSet.employee);
                Console.WriteLine("updating empl");
            }
            catch { Console.WriteLine("update failed"); }
        }

        private void buttonProdSave_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Update(myDataSet.product);
        }

        //delete buttons
        private void buttonDelRowBakery_Click(object sender, EventArgs e)
        {
            this.bakeryBindingSource.RemoveCurrent();
        }

        private void buttonEmplDel_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.RemoveCurrent();
        }

        private void buttonProdDel_Click(object sender, EventArgs e)
        {
            this.productBindingSource.RemoveCurrent();
        }
    }
}
