namespace placeholder;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        // Optional: Add some controls to the GroupBox programmatically
        AddControlsToGroupBox();
    }
    
    private void AddControlsToGroupBox()
    {
        // Example: Add a label to the group box
        Label label1 = new Label
        {
            Text = "This is inside the GroupBox",
            Location = new System.Drawing.Point(20, 30),
            AutoSize = true
        };
        
        // Example: Add a button to the group box
        Button button1 = new Button
        {
            Text = "Click Me",
            Location = new System.Drawing.Point(20, 60),
            Size = new System.Drawing.Size(100, 30)
        };
        
        // Add the controls to the group box
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(button1);
    }
}