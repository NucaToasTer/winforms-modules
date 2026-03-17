using System;
using System.Windows.Forms;

namespace boilerplate;

public partial class Form1 : Form
{
    private SaveData _save;

    public Form1()
    {
        InitializeComponent();

        // Load on startup
        _save = SaveManager.Load();
        DisplaySavedTexts();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string message = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(message))
            {
                // Add to save data and persist immediately
                _save.SavedTexts.Add(message);
                _save.SavedTexts2.Add(message);
                SaveManager.Save(_save);

                DisplaySavedTexts();
                textBox1.Clear();
            }

            e.SuppressKeyPress = true;
        }
    }

    private void DisplaySavedTexts()
    {
        if (_save.SavedTexts.Count == 0)
        {
            label1.Text = "No saved entries yet.";
            return;
        }

        // Show the most recent 5 entries, newest first
        var recent = _save.SavedTexts2
            .AsEnumerable()
            .Reverse()
            .Take(5);

        label1.Text = string.Join("\n", recent);
    }
}
