namespace placeholder;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.Windows.Forms.Label lblTimer;
    private System.Windows.Forms.Button btnStartStop;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Timer timer1;

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
        this.lblTimer = new System.Windows.Forms.Label();
        this.btnStartStop = new System.Windows.Forms.Button();
        this.btnReset = new System.Windows.Forms.Button();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // lblTimer
        // 
        this.lblTimer.AutoSize = true;
        this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblTimer.Location = new System.Drawing.Point(300, 100);
        this.lblTimer.Name = "lblTimer";
        this.lblTimer.Size = new System.Drawing.Size(200, 37);
        this.lblTimer.TabIndex = 0;
        this.lblTimer.Text = "00:00:00";
        this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnStartStop
        // 
        this.btnStartStop.Location = new System.Drawing.Point(250, 200);
        this.btnStartStop.Name = "btnStartStop";
        this.btnStartStop.Size = new System.Drawing.Size(100, 40);
        this.btnStartStop.TabIndex = 1;
        this.btnStartStop.Text = "Start";
        this.btnStartStop.UseVisualStyleBackColor = true;
        this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
        // 
        // btnReset
        // 
        this.btnReset.Location = new System.Drawing.Point(450, 200);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(100, 40);
        this.btnReset.TabIndex = 2;
        this.btnReset.Text = "Reset";
        this.btnReset.UseVisualStyleBackColor = true;
        this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
        // 
        // timer1
        // 
        this.timer1.Interval = 1000;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // Form1
        // 
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.btnStartStop);
        this.Controls.Add(this.lblTimer);
        this.Text = "Timer App";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
