using System;
using System.Windows.Forms;

namespace boilerplate;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string message = textBox1.Text;

            Console.WriteLine("User entered: " + message);
            
            label1.Text = $"Last input from TextBox 1: {message}";

            textBox1.Clear();

            e.SuppressKeyPress = true;
        }
    }

}
