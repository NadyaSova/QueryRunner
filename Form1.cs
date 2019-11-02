using QuerySaver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuerySaver
{
    public partial class Form1 : Form
    {
        private const string DateFormat = "HH:mm:ss MM-dd-yyy";

        public Form1()
        {
            InitializeComponent();
            FillSettings();
            FillQuery();
        }

        private void FillSettings()
        {
            var settings = Settings.Default.DatabaseSettings;
            if (settings == null)
                return;
            else
                tabMain.SelectedTab = tabRunQuery;

            txtServer.Text = settings.Server;
            txtDatabase.Text = settings.Database;
            txtUser.Text = settings.Username;
            txtPassword.Text = settings.Password;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (!AreSettingsValid())
            {
                MessageBox.Show("Please fill all fields", "Warning");
                return;
            }

            Settings.Default.DatabaseSettings = new Models.Settings
            {
                Server = txtServer.Text.Trim(),
                Database = txtDatabase.Text.Trim(),
                Username = txtUser.Text.Trim(),
                Password = txtPassword.Text.Trim(),
            };
            Settings.Default.Save();

            MessageBox.Show("Settings saved", "Success");
        }

        private bool AreSettingsValid()
        {
            if (string.IsNullOrEmpty(txtDatabase.Text))
                return false;

            if (string.IsNullOrEmpty(txtServer.Text))
                return false;

            if (string.IsNullOrEmpty(txtUser.Text))
                return false;

            if (string.IsNullOrEmpty(txtPassword.Text))
                return false;

            return true;
        }

        private void tabMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tabRunQuery)
            {
                if( Settings.Default.DatabaseSettings == null)
                {
                    e.Cancel = true;
                    MessageBox.Show("Please save database settings first", "Warning");
                }
            }
        }

        private void FillQuery()
        {
            PopulateDateRange(48);
        }

        private void PopulateDateRange(int hours)
        {
            txtPostFrom.Text = DateTime.Now.AddHours(-hours).ToString(DateFormat);
            txtPostTo.Text = DateTime.Now.ToString(DateFormat);
        }

        private void btn6hours_Click(object sender, EventArgs e)
        {
            PopulateDateRange(6);
        }

        private void btn12hours_Click(object sender, EventArgs e)
        {
            PopulateDateRange(12);
        }

        private void btn24hours_Click(object sender, EventArgs e)
        {
            PopulateDateRange(24);
        }

        private void btn36hours_Click(object sender, EventArgs e)
        {
            PopulateDateRange(36);
        }

        private void btn48hours_Click(object sender, EventArgs e)
        {
            PopulateDateRange(48);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLocations.Text = string.Empty;
            txtJobTitles.Text = string.Empty;
            txtExcludeCompany.Text = string.Empty;

            FillQuery();
        }
    }
}
