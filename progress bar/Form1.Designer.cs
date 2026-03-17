﻿namespace placeholder;

partial class Form1
{

    private System.ComponentModel.IContainer components = null;

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
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.SuspendLayout();
        
        this.progressBar1.Location = new System.Drawing.Point(50, 200);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(700, 30);
        this.progressBar1.TabIndex = 0;
        this.progressBar1.Value = 50;

        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.progressBar1);
        this.Text = "Form1 with Progress Bar";
        this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
}
