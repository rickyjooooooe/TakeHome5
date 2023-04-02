using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TakeHomeW5_RickyJonathan_0706022210005
{
    public partial class Form1 : Form
    {
        DataTable produk = new DataTable();//dtproduksimpan
        DataTable category = new DataTable();//dtcategory
        DataTable dtproduktampil = new DataTable();
        List<string> listidprod = new List<string>();
        List<string> listnamaprod = new List<string>();
        List<int> listharga = new List<int>();
        List<int> liststock = new List<int>();
        List<string> listidcat = new List<string>();
        List<string> listnamacat = new List<string>();
        List<string> listidcatt = new List<string>();
        List<int> filteredIndexes = new List<int>();
        DataRow newRow;
        DataRow row;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtcategory.SelectionChanged += new EventHandler(dtcategory_SelectionChanged);
            dtproduksimpan.SelectionChanged += new EventHandler(dtproduksimpan_CellMouseClick);
            textboxharga.KeyPress += new KeyPressEventHandler(textboxharga_KeyPress);
            textboxstok.KeyPress += new KeyPressEventHandler(textboxstok_KeyPress);
            this.Shown += new System.EventHandler(this.Form1_Shown);

            BackColor = Color.LightSalmon;
            buttonaddprod.BackColor = Color.Green;
            buttonedit.BackColor = Color.Yellow;
            buttonremoveprod.BackColor = Color.Red;
            buttonaddcat.BackColor = Color.Green;
            buttonremovecat.BackColor = Color.Red;
            produk.Columns.Add("ID Produk");
            produk.Columns.Add("Nama Produk");
            produk.Columns.Add("Harga");
            produk.Columns.Add("Stok");
            produk.Columns.Add("ID Category");
            dtproduksimpan.DataSource = produk;
            dtproduktampil.Columns.Add("ID Produk");
            dtproduktampil.Columns.Add("Nama Produk");
            dtproduktampil.Columns.Add("Harga");
            dtproduktampil.Columns.Add("Stok");
            dtproduktampil.Columns.Add("ID Category");
            category.Columns.Add("Id Category");
            category.Columns.Add("Nama Category");

            dtcategory.DataSource = category;
            listidprod.Add("J001");
            listidprod.Add("T001");
            listidprod.Add("T002");
            listidprod.Add("R001");
            listidprod.Add("J002");
            listidprod.Add("C001");
            listidprod.Add("C002");
            listidprod.Add("R002");
            listnamaprod.Add("Jas Hitam");
            listnamaprod.Add("T-Shirt Blackpink");
            listnamaprod.Add("T-Shirt Obsessive");
            listnamaprod.Add("Rok Mini");
            listnamaprod.Add("Jeans Biru");
            listnamaprod.Add("Celana Pendek Coklat");
            listnamaprod.Add("Cawat Blink-Blink");
            listnamaprod.Add("Rocca Shirt");
            listharga.Add(100000);
            listharga.Add(70000);
            listharga.Add(75000);
            listharga.Add(82000);
            listharga.Add(90000);
            listharga.Add(60000);
            listharga.Add(1000000);
            listharga.Add(50000);
            liststock.Add(10);
            liststock.Add(20);
            liststock.Add(16);
            liststock.Add(26);
            liststock.Add(5);
            liststock.Add(11);
            liststock.Add(1);
            liststock.Add(8);
            listidcat.Add("C1");
            listidcat.Add("C2");
            listidcat.Add("C2");
            listidcat.Add("C3");
            listidcat.Add("C4");
            listidcat.Add("C4");
            listidcat.Add("C5");
            listidcat.Add("C2");
            listidcatt.Add("C1");
            listidcatt.Add("C2");
            listidcatt.Add("C3");
            listidcatt.Add("C4");
            listidcatt.Add("C5");
            listnamacat.Add("Jas");
            listnamacat.Add("T-Shirt");
            listnamacat.Add("Rok");
            listnamacat.Add("Celana");
            listnamacat.Add("Cawat");

            for (int k = 0; k < listidprod.Count; k++)
            {
                produk.Rows.Add(listidprod[k], listnamaprod[k],
                listharga[k], liststock[k], listidcat[k]);
            }
            for (int i = 0; i < listidcatt.Count; i++)
            {
                category.Rows.Add(listidcatt[i], listnamacat[i]);
                comboboxfilter.Items.Add(listnamacat[i]);
                comboboxcat.Items.Add(listnamacat[i]);
            }
            textboxnama.Text = "";
            textboxharga.Text = "";
            textboxstok.Text = "";
            textboxnamacat.Text = "";
            comboboxcat.Text = "";
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            dtproduksimpan.CurrentCell = null;
            dtcategory.CurrentCell = null;
        }
        private void RefreshCategoryDataGridView()
        {
            category.Rows.Clear();
            for (int j = 0; j < listidcatt.Count; j++)
            {
                row = category.NewRow();
                row[0] = listidcatt[j];
                row[1] = listnamacat[j];
                category.Rows.Add(row);
            }
        }
        private void RefreshCombobox()
        {
            comboboxcat.Items.Clear();
            comboboxfilter.Items.Clear();
            for (int i = 0; i < listidcatt.Count; i++)
            {

                comboboxfilter.Items.Add(listnamacat[i]);
                comboboxcat.Items.Add(listnamacat[i]);
            }
        }


        private void RefreshProductDataGridView()
        {
            if (comboboxfilter.SelectedIndex != -1)
            {
               
                dtproduksimpan.DataSource = dtproduktampil;
            }
            else
            {
                
                dtproduksimpan.DataSource = produk;
            }
            dtproduksimpan.Refresh();
        }
        private void buttonall_Click(object sender, EventArgs e)
        {
            comboboxfilter.Enabled = false;
            
            dtproduksimpan.DataSource = produk;
            dtproduksimpan.ClearSelection();
            textboxnama.Text = "";
            textboxharga.Text = "";
            textboxstok.Text = "";
            comboboxcat.Text = "";
        }

        private void buttonfilter_Click(object sender, EventArgs e)
        {
            comboboxfilter.Enabled = true;
            
        }

        private void buttonaddprod_Click(object sender, EventArgs e)
        {
            if (textboxnama.Text == "" || textboxharga.Text == "" || textboxstok.Text == "")
            {
                MessageBox.Show("DIISI YANG LENGKAP", "ERROR");
            }
            else if (comboboxcat.SelectedIndex == -1)
            {
                MessageBox.Show("PILIH CATEGORY", "ERROR");
            }
            else
            {
                string pertama = textboxnama.Text.Substring(0, 1).ToUpper();
                int count = produk.AsEnumerable()
                         .Where(r => r.Field<string>("ID Produk").StartsWith(pertama))
                         .Count();

                string idProduk = pertama + (count + 1).ToString("D3");
                DataRow newRow = produk.NewRow();
                newRow["ID Produk"] = idProduk;
                newRow["Nama Produk"] = textboxnama.Text;
                newRow["Harga"] = textboxharga.Text;
                newRow["Stok"] = textboxstok.Text;
                int catIndex = listnamacat.IndexOf(comboboxcat.SelectedItem.ToString());
                newRow["ID Category"] = listidcatt[catIndex];
                produk.Rows.Add(newRow);

                listidprod.Add(idProduk);
                listnamaprod.Add(textboxnama.Text);
                listharga.Add(Convert.ToInt32(textboxharga.Text));
                liststock.Add(Convert.ToInt32(textboxstok.Text));
                // Clear the textboxes
                textboxnama.Text = "";
                textboxharga.Text = "";
                textboxstok.Text = "";
                comboboxcat.Text = "";
            }
        }
        private void textboxharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textboxstok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void buttonaddcat_Click(object sender, EventArgs e)
        {
            string yoo = "";
            if (textboxnamacat.Text == "")
            {
                MessageBox.Show("DIISI DULU", "ERROR");
            }
            else
            {
                if (listnamacat.Contains(textboxnamacat.Text))
                {
                    MessageBox.Show("SUDAH ADA", "ERROR");
                }
                else
                {
                    int lastIdIndex = listidcatt.Count - 1;
                    string lastId = listidcatt[lastIdIndex];
                    int newIdNum = Int32.Parse(lastId.Substring(1)) + 1;
                    yoo = "C" + newIdNum;
                    listnamacat.Add(textboxnamacat.Text);
                    listidcatt.Add(yoo);
                    comboboxfilter.Items.Add(textboxnamacat.Text);
                    comboboxcat.Items.Add(textboxnamacat.Text);
                    newRow = category.NewRow();
                    newRow["ID Category"] = yoo;
                    newRow["Nama Category"] = textboxnamacat.Text;
                    category.Rows.Add(newRow);

                    textboxnamacat.Text = "";
                }
            }
        }

        private void buttonremovecat_Click(object sender, EventArgs e)
        {
            if (category.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxnamacat.Text = "";
                return;
            }

            int index = dtcategory.CurrentCell.RowIndex;
            if (dtcategory.SelectedRows.Count == 0)
            {
                return;
            }

            string selectedCategoryId = listidcatt[index];

          
            for (int i = listidcat.Count - 1; i >= 0; i--)
            {
                if (listidcat[i] == selectedCategoryId)
                {
                    listidprod.RemoveAt(i);
                    listnamaprod.RemoveAt(i);
                    listharga.RemoveAt(i);
                    liststock.RemoveAt(i);
                    listidcat.RemoveAt(i);
                }
            }

           
            listidcatt.RemoveAt(index);
            listnamacat.RemoveAt(index);


            RefreshCategoryDataGridView();
            produk.Rows.Clear();
            for (int k = 0; k < listidprod.Count; k++)
            {
                produk.Rows.Add(listidprod[k], listnamaprod[k],
                listharga[k], liststock[k], listidcat[k]);
            }
            RefreshCombobox();

  
            comboboxfilter.Items.Clear();
            comboboxcat.Items.Clear();
            foreach (string catName in listnamacat)
            {
                comboboxfilter.Items.Add(catName);
                comboboxcat.Items.Add(catName);
            }


            textboxnamacat.Text = "";
            dtproduksimpan.ClearSelection();
            dtcategory.ClearSelection();
        }

        private void dtcategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dtcategory.SelectedRows.Count > 0)
            {
                int rowIndex = dtcategory.SelectedRows[0].Index;
                string namaCategory = dtcategory.Rows[rowIndex].Cells["Nama Category"].Value.ToString();
                textboxnamacat.Text = namaCategory;
            }
        }
        private void dtproduksimpan_CellMouseClick(object sender, EventArgs e)
        {
            if (dtproduksimpan.SelectedRows.Count > 0)
            {



                textboxnama.Text = dtproduksimpan.CurrentRow.Cells["Nama Produk"].Value.ToString();
                textboxharga.Text = dtproduksimpan.CurrentRow.Cells["Harga"].Value.ToString();
                textboxstok.Text = dtproduksimpan.CurrentRow.Cells["Stok"].Value.ToString();
                    string catid = dtproduksimpan.CurrentRow.Cells["ID Category"].Value.ToString();
                    int index = listidcatt.FindIndex(a => a.Contains(dtproduksimpan.CurrentRow.Cells["ID Category"].Value.ToString()));
                    string catname = listnamacat[index];
                    
                    comboboxcat.Text = catname;
                
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            if (dtproduksimpan.SelectedRows.Count == 0)
            {
                MessageBox.Show("PILIH DULU PRODUKNYA", "ERROR");
            }
            else
            {
                int index = listidprod.FindIndex(a => a.Contains(dtproduksimpan.CurrentRow.Cells["ID Produk"].Value.ToString()));
                string idbaru = listidcatt[comboboxcat.SelectedIndex];
                for (int i = 0; i < produk.Rows.Count; i++)
                {
                    DataRow row = produk.Rows[i];

                    if (row[0].ToString() == listidprod[index])
                    {
                        row[1] = textboxnama.Text;
                        row[2] = textboxharga.Text;
                        row[3] = textboxstok.Text;
                        row[4] = idbaru;

                        if (row[3].ToString() == "0")
                        {
                            produk.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
                textboxnama.Text = "";
                textboxharga.Text = "";
                textboxstok.Text = "";
                comboboxcat.Text = "";
            }
        }

        private void buttonremoveprod_Click(object sender, EventArgs e)
        {
            if (dtproduksimpan.SelectedRows.Count != 0)
            {
                int rowIndex = dtproduksimpan.CurrentCell.RowIndex;
                string selectedId = dtproduksimpan.Rows[rowIndex].Cells[0].Value.ToString();


                listidprod.Remove(selectedId);


                listnamaprod.RemoveAt(rowIndex);
                listharga.RemoveAt(rowIndex);
                liststock.RemoveAt(rowIndex);
                listidcat.RemoveAt(rowIndex);


                DataRow[] rows = produk.Select($"[ID Produk] = '{selectedId}'");
                foreach (DataRow row in rows)
                {
                    produk.Rows.Remove(row);
                }


                string filter = comboboxfilter.Text;
                if (!string.IsNullOrEmpty(filter))
                {
                    dtproduktampil.DefaultView.RowFilter = $"[ID Category] = '{category.Rows[comboboxfilter.SelectedIndex][0].ToString()}'";
                    dtproduksimpan.DataSource = dtproduktampil.DefaultView;
                }
                else
                {
                    dtproduktampil.Clear();
                    foreach (DataRow row in produk.Rows)
                    {
                        dtproduktampil.Rows.Add(row["ID Produk"], row["Nama Produk"], row["Harga"], row["Stok"], row["ID Category"]);
                    }
                    dtproduksimpan.DataSource = dtproduktampil;
                }

                string selectedCatName = textboxnamacat.Text;
                if (comboboxfilter.Items.Contains(selectedCatName))
                {
                    comboboxfilter.Items.Remove(selectedCatName);
                }
                if (comboboxcat.Items.Contains(selectedCatName))
                {
                    comboboxcat.Items.Remove(selectedCatName);
                }


                RefreshCategoryDataGridView();
                RefreshProductDataGridView();
                RefreshCombobox();


                comboboxfilter.Items.Clear();
                comboboxcat.Items.Clear();
                foreach (string catName in listnamacat)
                {
                    comboboxfilter.Items.Add(catName);
                    comboboxcat.Items.Add(catName);
                }

                textboxnamacat.Text = "";
                dtproduksimpan.ClearSelection();
                dtcategory.ClearSelection();
            }
            dtproduksimpan.DataSource = produk;
        }

        private void comboboxfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtproduksimpan.DataSource = dtproduktampil;
            string selectedCatName = comboboxfilter.Text;
            if (comboboxfilter.Items.Contains(selectedCatName))
            {
                dtproduktampil.Clear();
                foreach (DataRow row in category.Rows)
                {
                    if (selectedCatName == row[1].ToString())
                    {
                        foreach (DataRow dataRow in produk.Rows)
                        {
                            if (dataRow["ID Category"].ToString() == row[0].ToString())
                            {
                                dtproduktampil.Rows.Add(dataRow["ID Produk"], dataRow["Nama Produk"], dataRow["Harga"], dataRow["Stok"], dataRow["ID Category"]);
                            }
                        }
                    }
                }
                dtproduksimpan.ClearSelection();
            }
        }

    }
}
