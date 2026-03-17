namespace boilerplate;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";


        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox1.Location = new System.Drawing.Point(20, 20);
        this.textBox1.Size = new System.Drawing.Size(300, 23);
        this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
        this.Controls.Add(this.textBox1);


        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new System.Drawing.Point(20, 60);
        this.label1.Size = new System.Drawing.Size(400, 120);
        this.label1.Text = "No saved entries yet.";
        this.label1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
        this.label1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
        this.Controls.Add(this.label1);
    }
}
