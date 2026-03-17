namespace placeholder;

public partial class Form1 : Form
{
    private TimeSpan elapsedTime;
    private bool isRunning;

    public Form1()
    {
        InitializeComponent();
        elapsedTime = TimeSpan.Zero;
        isRunning = false;
        UpdateTimerDisplay();
    }

    private void btnStartStop_Click(object sender, EventArgs e)
    {
        if (isRunning)
        {
            timer1.Stop();
            btnStartStop.Text = "Start";
        }
        else
        {
            timer1.Start();
            btnStartStop.Text = "Stop";
        }
        isRunning = !isRunning;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        timer1.Stop();
        elapsedTime = TimeSpan.Zero;
        isRunning = false;
        btnStartStop.Text = "Start";
        UpdateTimerDisplay();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");
    }
}
