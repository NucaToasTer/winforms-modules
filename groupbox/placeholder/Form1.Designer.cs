﻿namespace placeholder;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        
        // groupBox1
        this.groupBox1.Text = "My Group Box";
        this.groupBox1.Location = new System.Drawing.Point(50, 50);
        this.groupBox1.Size = new System.Drawing.Size(300, 200);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.BackColor = System.Drawing.Color.Transparent;
        this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        
        // Form1
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        this.Controls.Add(this.groupBox1);
    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
}