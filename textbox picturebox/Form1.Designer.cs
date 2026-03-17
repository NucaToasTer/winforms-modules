namespace boilerplate;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.PictureBox pictureBox1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

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

        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.pictureBox1.Location = new System.Drawing.Point(20, 100);
        this.pictureBox1.Size = new System.Drawing.Size(300, 200);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.Image = System.Drawing.Image.FromFile("assets/image.png");
        this.Controls.Add(this.pictureBox1);
    }

    #endregion
}
