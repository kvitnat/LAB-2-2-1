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

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            string emName = textBoxName.Text;
            string emSurname = textBoxSurname.Text;
            string emPos = comboBoxPos.SelectedValue.ToString();
            string emBakery = comboBoxBakery.SelectedValue.ToString();

            string sql = string.Format("Insert Into employee" +
                   "(EM_NAME, EM_SURNAME, EM_BK, EM_P) Values(@emN, @emS, @emB, @emP)");

            using (SqlCommand cmd = new SqlCommand(sql, bakeryTableAdapter.Connection))
            {
                cmd.Parameters.AddWithValue("@emN", emName);
                cmd.Parameters.AddWithValue("@emS", emSurname);
                cmd.Parameters.AddWithValue("@emB", emBakery);
                cmd.Parameters.AddWithValue("@emP", emPos);

                bakeryTableAdapter.Connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Не удалось добавить сотрудника.");
                }
            }
            myDataSet.employee.Clear();
            employeeTableAdapter.Fill(myDataSet.employee);
        }

        //delete buttons
        private void buttonDelRowBakery_Click(object sender, EventArgs e)
        {
            int r = -1;
            r = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BK_ID"].Value);

            MessageBox.Show("____" + r + "____");
            if (employeeTableAdapter.ScalarQuery(r) == 0)
            {
                this.bakeryBindingSource.RemoveCurrent();
                this.bakeryTableAdapter.Update(myDataSet.bakery);
            }
            else
                MessageBox.Show("Нельзя удалить пекарню - увольте работников!");
        }

        private void buttonEmplDel_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.RemoveCurrent();
            this.employeeTableAdapter.Update(myDataSet.employee);
        }

        private void buttonProdDel_Click(object sender, EventArgs e)
        {
            this.productBindingSource.RemoveCurrent();
            this.productTableAdapter.Update(myDataSet.product);
        }



        private void buttonDelCat_Click(object sender, EventArgs e)
        {
            int r = -1;
            r = Convert.ToInt32(dataGridView4.CurrentRow.Cells["CT_ID"].Value);

            MessageBox.Show("____" + r + "____");
            if (productTableAdapter.ScalarQueryPrCat(r) == 0)
            {
                this.categoriesBindingSource.RemoveCurrent();
                this.categoriesTableAdapter.Update(myDataSet.categories);
            }
            else
                MessageBox.Show("Нельзя удалить непустую категорию");
        }

        private void buttonProdSearch_Click(object sender, EventArgs e)
        {
            find_products();
        }

        private void find_products()
        {
            if (checkBoxProdName.Checked && !checkBoxProdPrice.Checked && !checkBoxProdCateg.Checked)
            {
                this.productTableAdapter.FillByProductName(myDataSet.product, "%" + textBoxProdName.Text + "%");
            }

            if (!checkBoxProdName.Checked && checkBoxProdPrice.Checked && !checkBoxProdCateg.Checked)
            {
                try
                {
                    decimal priceFrom = Convert.ToDecimal(textBoxProdPriceFrom.Text),
                            priceTo = Convert.ToDecimal(textBoxProdPriceTo.Text);
                    this.productTableAdapter.FillByProdPrice(myDataSet.product, priceFrom, priceTo);
                }
                catch
                {
                    MessageBox.Show("Не удалось считать числовое значение (используйте запятую вместо точки)");
                }
            }
        }

        private void buttonProdDefault_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(myDataSet.product);
        }
    }
}
