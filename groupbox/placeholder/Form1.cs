namespace placeholder;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        AddControlsToGroupBox();
    }
    
    private void AddControlsToGroupBox()
    {

        Label label1 = new Label
        {
            Text = "This is inside the GroupBox",
            Location = new System.Drawing.Point(20, 30),
            AutoSize = true
        };
        
        Button button1 = new Button
        {
            Text = "Click Me",
            Location = new System.Drawing.Point(20, 60),
            Size = new System.Drawing.Size(100, 30)
        };
        
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(button1);
    }
}
