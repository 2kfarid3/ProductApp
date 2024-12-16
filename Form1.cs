namespace ProductApp
{
    public partial class Form1 : Form
    {
        public int cur_id;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.Name = "deleteButton";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(deleteButtonColumn);

            LoadData();
        }

        private void LoadData()
        {
            using (var db = new appDbContext())
            {
                dgv.DataSource = db.Products.ToList();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                cur_id = Convert.ToInt32(row.Cells["Id"].Value);
                name_tb.Text = row.Cells["Name"].Value.ToString();
                desc_tb.Text = row.Cells["Description"].Value.ToString();
                cat_tb.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void ClearTbs(TextBox[] tbs)
        {
            foreach (TextBox t in tbs)
            {
                t.Text = string.Empty;
            }
        }

        private void insert_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Name = name_tb.Text,
                    Description = desc_tb.Text,
                    Category = cat_tb.Text
                };

                using (var db = new appDbContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                    LoadData();
                    ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });

                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {
            if (cur_id > -1)
            {
                using (var db = new appDbContext())
                {
                    Product p = db.Products.Find(cur_id);
                    p.Name = name_tb.Text;
                    p.Description = desc_tb.Text;
                    p.Category = cat_tb.Text;

                    db.Products.Update(p);
                    db.SaveChanges();
                    LoadData();
                    ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cur_id > -1)
                {
                    using (var db = new appDbContext())
                    {
                        Product product = db.Products.Find(cur_id);

                        if (product != null)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            LoadData();
                            ClearTbs(new TextBox[] { name_tb, desc_tb, cat_tb });

                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
                DeleteProduct(productId);
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                using (var db = new appDbContext())
                {
                    var product = db.Products.FirstOrDefault(p => p.Id == productId);
                    if (product != null)
                    {
                        db.Products.Remove(product);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Product deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
