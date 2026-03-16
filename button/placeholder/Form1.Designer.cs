namespace boilerplate;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button button1;

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
        this.ClientSize = new System.Drawing.Size(300, 150);
        this.Text = "Form1";
        
        this.button1 = new System.Windows.Forms.Button();
        this.button1.Location = new System.Drawing.Point(20, 20);
        this.button1.Size = new System.Drawing.Size(100, 30);
        this.button1.Text = "Click Me";
        this.button1.Click += new System.EventHandler(this.button1_Click);
        this.Controls.Add(this.button1);
    }

    #endregion
}
