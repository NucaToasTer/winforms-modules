﻿namespace boilerplate;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ListBox listBox1;

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
        
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox2.Location = new System.Drawing.Point(20, 60);
        this.textBox2.Size = new System.Drawing.Size(300, 23);
        this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
        this.Controls.Add(this.textBox2);
        
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.listBox1.Location = new System.Drawing.Point(20, 100);
        this.listBox1.Size = new System.Drawing.Size(300, 100);
        
        this.listBox1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2"
        });
        
        this.Controls.Add(this.listBox1);
    }

    #endregion
}
