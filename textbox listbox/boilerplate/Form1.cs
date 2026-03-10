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
            
            // Optional: Add the entered text to the ListBox
            listBox1.Items.Add("User 1: " + message);

            textBox1.Clear();

            e.SuppressKeyPress = true; // prevents ding sound
        }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string message = textBox2.Text;

            Console.WriteLine("User 2 entered: " + message);
            
            // Optional: Add the entered text to the ListBox
            listBox1.Items.Add("User 2: " + message);

            textBox2.Clear();

            e.SuppressKeyPress = true; // prevents ding sound
        }
    }
}