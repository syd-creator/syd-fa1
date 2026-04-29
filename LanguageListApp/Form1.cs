using System;
using System.Windows.Forms;

namespace LanguageListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = txtLanguage.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter a programming language.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicates
            if (lstLanguages.Items.Contains(input))
            {
                MessageBox.Show("This language is already in the list.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add item
            lstLanguages.Items.Add(input);

            // Update time
            lblDateTime.Text = DateTime.Now.ToString();

            txtLanguage.Clear();
            txtLanguage.Focus();
        }

        // Remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedIndex != -1)
            {
                string removedLanguage = lstLanguages.SelectedItem.ToString();

                lstLanguages.Items.RemoveAt(lstLanguages.SelectedIndex);

                // Update time
                lblDateTime.Text = DateTime.Now.ToString();
            }
            else
            {
                MessageBox.Show("Please select a language to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}