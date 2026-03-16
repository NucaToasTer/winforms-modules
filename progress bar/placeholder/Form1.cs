namespace placeholder;

public partial class Form1 : Form
{
    private System.Windows.Forms.Timer timer;

    public Form1()
    {
        InitializeComponent();
        
        timer = new System.Windows.Forms.Timer();
        timer.Interval = 100;
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {

        if (progressBar1.Value < progressBar1.Maximum)
        {
            progressBar1.Value += 1;
        }
        else
        {
            progressBar1.Value = progressBar1.Minimum;
        }
    }
}
