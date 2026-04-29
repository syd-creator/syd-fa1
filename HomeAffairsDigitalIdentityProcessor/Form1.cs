using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        CitizenProfile profile;

        public Form1()
        {
            InitializeComponent();

            cmbCitizenship.Items.Add("Citizen");
            cmbCitizenship.Items.Add("Permanent Resident");
            cmbCitizenship.Items.Add("Visitor");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string id = txtIDNumber.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem?.ToString();

            profile = new CitizenProfile(name, id, citizenship);

            string result = profile.ValidateID();

            txtOutput.Text = result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (profile == null)
            {
                MessageBox.Show("Please validate ID first.");
                return;
            }

            string output =
                "----- PROFILE SUMMARY -----\n" +
                "Name: " + profile.FullName + "\n" +
                "ID: " + profile.IDNumber + "\n" +
                "Age: " + profile.Age + "\n" +
                "Citizenship: " + profile.CitizenshipStatus + "\n" +
                "Status: " + profile.ValidateID() + "\n" +
                "Processed: " + DateTime.Now;

            txtOutput.Text = output;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}