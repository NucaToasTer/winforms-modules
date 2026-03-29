namespace placeholder;

public partial class Form1 : Form
{
    private List<Product> _products = new();
    private bool _inserting = false;
    private int _pendingEditRow = -1;
    private int _pendingDeleteId = -1;

    public Form1()
    {
        InitializeComponent();
        LoadGrid();
    }

    private void LoadGrid()
    {
        _inserting = false;
        _pendingEditRow = -1;
        _pendingDeleteId = -1;
        confirmButton.Visible = false;

        dataGridView1.DataSource = null;
        dataGridView1.Columns.Clear();

        _products = Product.All().ToList();
        dataGridView1.DataSource = _products;
        dataGridView1.RowHeadersVisible = false;

        if (dataGridView1.Columns["ID"] is { } id)
            id.ReadOnly = true;

        if (dataGridView1.Columns["Price"] is { } price)
            price.DefaultCellStyle.Format = "C2";

        AddActionColumns();
    }

    private void AddActionColumns()
    {
        dataGridView1.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "EditBtn",
            HeaderText = "",
            Text = "Edit",
            UseColumnTextForButtonValue = true,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            Width = 60
        });

        dataGridView1.Columns.Add(new DataGridViewButtonColumn
        {
            Name = "DeleteBtn",
            HeaderText = "",
            Text = "Delete",
            UseColumnTextForButtonValue = true,
            AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
            Width = 60
        });
    }

    private void ShowConfirm(string label)
    {
        confirmButton.Text = label;
        confirmButton.Visible = true;
    }

    private void findButton_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(idTextBox.Text.Trim(), out var id))
        {
            MessageBox.Show("Please enter a valid numeric ID.", "Invalid ID",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var product = Product.FindById(id);

        if (product == null)
        {
            MessageBox.Show($"No product found with ID {id}.", "Not Found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView2.Visible = false;
            return;
        }

        dataGridView2.DataSource = null;
        dataGridView2.DataSource = new List<Product> { product };

        if (dataGridView2.Columns["Price"] is { } price)
            price.DefaultCellStyle.Format = "C2";

        dataGridView2.Visible = true;
    }

    private void insertButton_Click(object? sender, EventArgs e)
    {
        if (_inserting) return;
        _inserting = true;

        dataGridView1.DataSource = null;
        dataGridView1.Columns.Clear();
        dataGridView1.RowHeadersVisible = false;
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID",           HeaderText = "ID",       ReadOnly = true });
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Product_Name",  HeaderText = "Product"  });
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Category",      HeaderText = "Category" });
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Price",         HeaderText = "Price"    });
        dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Stock",         HeaderText = "Stock"    });
        AddActionColumns();

        foreach (var p in _products)
            dataGridView1.Rows.Add(p.ID, p.Product_Name, p.Category, p.Price, p.Stock, "Edit", "Delete");

        var idx = dataGridView1.Rows.Add(null, "", "", "", "", "", "Cancel");
        dataGridView1.CurrentCell = dataGridView1.Rows[idx].Cells["Product_Name"];
        dataGridView1.BeginEdit(true);

        ShowConfirm("Confirm Insert");
    }

    private void confirmButton_Click(object? sender, EventArgs e)
    {
        if (_inserting)
        {
            var row = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
            dataGridView1.EndEdit();
            var name     = row.Cells["Product_Name"].Value?.ToString() ?? "";
            var category = row.Cells["Category"].Value?.ToString() ?? "";
            var price    = decimal.TryParse(row.Cells["Price"].Value?.ToString(), out var p) ? p : 0;
            var stock    = int.TryParse(row.Cells["Stock"].Value?.ToString(), out var s) ? s : 0;
            Product.Insert(name, category, price, stock);
            ShowConfirm("Product Inserted ✓");
        }
        else if (_pendingEditRow >= 0)
        {
            var row = dataGridView1.Rows[_pendingEditRow];
            dataGridView1.EndEdit();
            var id       = Convert.ToInt32(row.Cells["ID"].Value);
            var name     = row.Cells["Product_Name"].Value?.ToString() ?? "";
            var category = row.Cells["Category"].Value?.ToString() ?? "";
            var price    = decimal.TryParse(row.Cells["Price"].Value?.ToString(), out var p) ? p : 0;
            var stock    = int.TryParse(row.Cells["Stock"].Value?.ToString(), out var s) ? s : 0;
            Product.Edit(id, name, category, price, stock);
            ShowConfirm("Product Updated ✓");
        }
        else if (_pendingDeleteId >= 0)
        {
            Product.Delete(_pendingDeleteId);
            ShowConfirm("Product Deleted ✓");
        }

        var timer = new System.Windows.Forms.Timer { Interval = 1000 };
        timer.Tick += (s, _) => { timer.Stop(); LoadGrid(); };
        timer.Start();
    }

    private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dataGridView1.Rows[e.RowIndex];
        var col = dataGridView1.Columns[e.ColumnIndex].Name;

        if (col == "DeleteBtn")
        {
            var btnValue = row.Cells["DeleteBtn"].Value?.ToString();

            if (btnValue == "Cancel")
            {
                LoadGrid();
                return;
            }

            if (_inserting) return;

            _pendingDeleteId = Convert.ToInt32(row.Cells["ID"].Value);
            ShowConfirm("Confirm Delete");
        }
        else if (col == "EditBtn")
        {
            if (_inserting) return;

            foreach (DataGridViewCell cell in row.Cells)
                cell.ReadOnly = cell.OwningColumn.Name is "EditBtn" or "DeleteBtn" or "ID";

            dataGridView1.CurrentCell = row.Cells["Product_Name"];
            dataGridView1.BeginEdit(true);

            _pendingEditRow = e.RowIndex;
            ShowConfirm("Confirm Edit");
        }
    }
}