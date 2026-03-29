namespace placeholder;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private DataGridView dataGridView1;
    private DataGridView dataGridView2;
    private Button insertButton;
    private Button confirmButton;
    private TextBox idTextBox;
    private Button findButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.dataGridView1 = new DataGridView();
        this.dataGridView2 = new DataGridView();
        this.insertButton = new Button();
        this.confirmButton = new Button();
        this.idTextBox = new TextBox();
        this.findButton = new Button();
        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridView2).BeginInit();
        this.SuspendLayout();

        // dataGridView1
        this.dataGridView1.Dock = DockStyle.Top;
        this.dataGridView1.Height = 200;
        this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.dataGridView1.BackgroundColor = SystemColors.Window;
        this.dataGridView1.AllowUserToAddRows = false;
        this.dataGridView1.AllowUserToDeleteRows = false;
        this.dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
        this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

        // idTextBox
        this.idTextBox.Dock = DockStyle.Top;
        this.idTextBox.Height = 30;
        this.idTextBox.PlaceholderText = "Enter Product ID...";

        // findButton
        this.findButton.Dock = DockStyle.Top;
        this.findButton.Text = "Find Product";
        this.findButton.Height = 35;
        this.findButton.Click += new EventHandler(findButton_Click);

        // dataGridView2
        this.dataGridView2.Dock = DockStyle.Top;
        this.dataGridView2.Height = 60;
        this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        this.dataGridView2.BackgroundColor = SystemColors.Window;
        this.dataGridView2.AllowUserToAddRows = false;
        this.dataGridView2.AllowUserToDeleteRows = false;
        this.dataGridView2.ReadOnly = true;
        this.dataGridView2.RowHeadersVisible = false;
        this.dataGridView2.Visible = false;

        // insertButton
        this.insertButton.Dock = DockStyle.Bottom;
        this.insertButton.Text = "Insert";
        this.insertButton.Height = 35;
        this.insertButton.Click += new EventHandler(insertButton_Click);

        // confirmButton
        this.confirmButton.Dock = DockStyle.Bottom;
        this.confirmButton.Height = 35;
        this.confirmButton.Visible = false;
        this.confirmButton.Click += new EventHandler(confirmButton_Click);

        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 600);
        this.Controls.Add(this.dataGridView2);
        this.Controls.Add(this.findButton);
        this.Controls.Add(this.idTextBox);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.insertButton);
        this.Controls.Add(this.confirmButton);
        this.Text = "Garage — Products";

        ((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.dataGridView2).EndInit();
        this.ResumeLayout(false);
    }
}