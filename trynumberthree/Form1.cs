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
using System.Data.Entity;
using BakeryDataEF;

namespace trynumberthree
{
    public partial class Form1 : Form
    {
        private BakeryDataEF.bakeries_networkEntities ctx;
        private BakeryDataEF.bakeries_networkEntities ctx_pr;

        public Form1()
        {
            InitializeComponent();
            ctx = new BakeryDataEF.bakeries_networkEntities();

            ctx.bakery.Load();
            this.bakeryBindingSource.DataSource = ctx.bakery.Local.ToBindingList();

            ctx.employee.Load();
            this.employeeBindingSource.DataSource = ctx.employee.Local.ToBindingList();

            ctx.product.Load();
            this.productBindingSource.DataSource = ctx.product.Local.ToBindingList();

            ctx.categories.Load();
            this.categoriesBindingSource.DataSource = ctx.categories.Local.ToBindingList();

            ctx.holders.Load();
            this.holdersBindingSource.DataSource = ctx.holders.Local.ToBindingList();

            ctx.positions.Load();
            this.positionsBindingSource.DataSource = ctx.positions.Local.ToBindingList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //save buttons
        private void buttonSaveBakery_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            
        }

        private void buttonEmplSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
            
        }

        private void buttonProdSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {

            string emName = textBoxName.Text;
            string emSurname = textBoxSurname.Text;
            int emPos = Convert.ToInt32(comboBoxPos.SelectedValue.ToString());
            int emBakery = Convert.ToInt32(comboBoxBakery.SelectedValue.ToString());

            employee empl = new employee
            {
                EM_NAME = emName,
                EM_SURNAME = emSurname,
                EM_P = emPos,
                EM_BK = emBakery
            };

            ctx.employee.Add(empl);
            ctx.SaveChanges();
        }

        //delete buttons
        private void buttonDelRowBakery_Click(object sender, EventArgs e)
        {
            try
            {
                bakery bkr = (bakery)dataGridView1.CurrentRow.DataBoundItem;
                var emp = (from c in ctx.employee where (c.EM_BK == bkr.BK_ID) select c).Any();
                if (emp)
                    MessageBox.Show("Нельзя удалить пекарню - увольте работников!");
                else
                {
                    bakeryBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
                    
            }
            catch(Exception)
            {
                MessageBox.Show("Error.");
                throw;
            }
            
        }

        private void buttonEmplDel_Click(object sender, EventArgs e)
        {
            employeeBindingSource.RemoveCurrent();
        }

        private void buttonProdDel_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }


        private void buttonDelCat_Click(object sender, EventArgs e)
        {
            try
            {
                categories ctg = (categories)dataGridView4.CurrentRow.DataBoundItem;
                var b = (from c in ctx.product where (c.PR_CAT == ctg.CT_ID) select c).Any();
                if (b)
                    MessageBox.Show("Нельзя удалить непустую категорию");
                else
                {
                    categoriesBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }

        }

        private void buttonProdSearch_Click(object sender, EventArgs e)
        {
            find_products();
        }

        private void find_products()
        {

            if (checkBoxProdName.Checked && !checkBoxProdPrice.Checked && !checkBoxProdCateg.Checked)
            {
                var products = (from p in ctx.product where p.PR_NAME.Contains(textBoxProdName.Text) select p).ToList();
                this.productBindingSource.DataSource = products;
                dataGridView3.Refresh();
            }

            if (!checkBoxProdName.Checked && checkBoxProdPrice.Checked && !checkBoxProdCateg.Checked)
            {
                try
                {
                    decimal priceFrom, priceTo;
                    if (textBoxProdPriceFrom.Text == "")
                        priceFrom = 0;
                    else
                        priceFrom = Convert.ToDecimal(textBoxProdPriceFrom.Text);

                    if (textBoxProdPriceTo.Text == "")
                        priceTo = 100;
                    else
                        priceTo = Convert.ToDecimal(textBoxProdPriceTo.Text);

                    var products = (from p in ctx.product where p.PR_COST >= priceFrom && p.PR_COST <= priceTo select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Не удалось считать числовое значение (используйте запятую вместо точки)");
                }
            }

            if (!checkBoxProdName.Checked && !checkBoxProdPrice.Checked && checkBoxProdCateg.Checked)
            {
                try
                {
                    int prodCatId = Convert.ToInt32(comboBoxProdCategory.SelectedValue);
                    var products = (from p in ctx.product where p.PR_CAT == prodCatId select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Ошибка категории");
                }
            }

            if (checkBoxProdName.Checked && checkBoxProdPrice.Checked && !checkBoxProdCateg.Checked)
            {
                try
                {
                    decimal priceFrom, priceTo;
                    if (textBoxProdPriceFrom.Text == "")
                        priceFrom = 0;
                    else
                        priceFrom = Convert.ToDecimal(textBoxProdPriceFrom.Text);

                    if (textBoxProdPriceTo.Text == "")
                        priceTo = 100;
                    else
                        priceTo = Convert.ToDecimal(textBoxProdPriceTo.Text);

                    var products = (from p in ctx.product where p.PR_NAME.Contains(textBoxProdName.Text) && 
                                                                p.PR_COST >= priceFrom && p.PR_COST <= priceTo select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Не удалось считать числовое значение (используйте запятую вместо точки)");
                }
            }

            if (checkBoxProdName.Checked && !checkBoxProdPrice.Checked && checkBoxProdCateg.Checked)
            {
                try
                {
                    int prodCatId = Convert.ToInt32(comboBoxProdCategory.SelectedValue);
                    var products = (from p in ctx.product where p.PR_NAME.Contains(textBoxProdName.Text) && p.PR_CAT == prodCatId select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Ошибка категории");
                }
            }

            if (!checkBoxProdName.Checked && checkBoxProdPrice.Checked && checkBoxProdCateg.Checked)
            {
                try
                {
                    decimal priceFrom, priceTo;
                    if (textBoxProdPriceFrom.Text == "")
                        priceFrom = 0;
                    else
                        priceFrom = Convert.ToDecimal(textBoxProdPriceFrom.Text);

                    if (textBoxProdPriceTo.Text == "")
                        priceTo = 100;
                    else
                        priceTo = Convert.ToDecimal(textBoxProdPriceTo.Text);

                    int prodCatId = Convert.ToInt32(comboBoxProdCategory.SelectedValue);

                    var products = (from p in ctx.product where p.PR_COST >= priceFrom && p.PR_COST <= priceTo && p.PR_CAT == prodCatId select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("Не удалось считать числовое значение (используйте запятую вместо точки)");
                }
            }


            if (checkBoxProdName.Checked && checkBoxProdPrice.Checked && checkBoxProdCateg.Checked)
            {
                try
                {
                    decimal priceFrom, priceTo;
                    if (textBoxProdPriceFrom.Text == "")
                        priceFrom = 0;
                    else
                        priceFrom = Convert.ToDecimal(textBoxProdPriceFrom.Text);

                    if (textBoxProdPriceTo.Text == "")
                        priceTo = 100;
                    else
                        priceTo = Convert.ToDecimal(textBoxProdPriceTo.Text);

                    int prodCatId = Convert.ToInt32(comboBoxProdCategory.SelectedValue);
                    var products = (from p in ctx.product where p.PR_NAME.Contains(textBoxProdName.Text) && p.PR_COST >= priceFrom && p.PR_COST <= priceTo && p.PR_CAT == prodCatId select p).ToList();
                    this.productBindingSource.DataSource = products;
                    dataGridView3.Refresh();
                }
                catch
                {
                    MessageBox.Show("ошибка поиска");
                }
            }

        }

        private void buttonProdDefault_Click(object sender, EventArgs e)
        {
            this.productBindingSource.DataSource = ctx.product.Local.ToBindingList();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Выход", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
                e.Cancel = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = -1;
            r = Convert.ToInt32(dataGridView1.CurrentRow.Cells["BK_ID"].Value);

            try
            {
                textBoxBakeryId.Text = r.ToString();
                textBoxBakeryAdrs.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + 
                                         Environment.NewLine + 
                                         dataGridView1.CurrentRow.Cells[2].Value.ToString();

                bakery bkr = (bakery)dataGridView1.CurrentRow.DataBoundItem;
                var b = (from c in ctx.employee where (c.EM_BK == bkr.BK_ID) select c).Count();
                textBoxBakeryCount.Text = b.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = -1;
            try
            {
                ctx_pr = new bakeries_networkEntities();
                r = Convert.ToInt32(dataGridView4.CurrentRow.Cells["CT_ID"].Value);
                categories ctg = (categories)dataGridView4.CurrentRow.DataBoundItem;
                var query = from p in ctx_pr.product where p.PR_CAT == ctg.CT_ID select p;
                query.Load();
                productBindingSource1.DataSource = ctx_pr.product.Local.ToBindingList();
            }
            catch(Exception)
            {

            }

            //MessageBox.Show("event " +  r);

            //this.productTableAdapter.FillByProdCateg(myDataSet.product, r);
        }
    }
}
