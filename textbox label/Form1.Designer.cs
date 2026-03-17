﻿namespace boilerplate;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    
    #region Windows Form Designer generated code;
    
    private void InitializeComponent()
    {

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        
        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new System.Drawing.Point(20, 100);
        this.label1.Size = new System.Drawing.Size(300, 50);
        this.label1.Text = "Enter text in the boxes above and press Enter";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.label1.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
        this.Controls.Add(this.label1);
        
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox1.Location = new System.Drawing.Point(20, 20);
        this.textBox1.Size = new System.Drawing.Size(300, 23);
        this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
        this.Controls.Add(this.textBox1);
    }

    #endregion

}
