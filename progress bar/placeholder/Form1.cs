namespace placeholder;

public partial class Form1 : Form
{
    private System.Windows.Forms.Timer timer; // Explicitly declare the timer type

    public Form1()
    {
        InitializeComponent();
        
        // Initialize and configure the timer
        timer = new System.Windows.Forms.Timer(); // Explicitly use Windows.Forms.Timer
        timer.Interval = 100; // 100ms
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object? sender, EventArgs e)
    {
        // Increment progress bar value
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