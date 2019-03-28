using System;
using System.Windows.Forms;

namespace UpdateAppLibrary
{
    public partial class NewRelease : Form
    {
        private YAppRelease release;
        public YAppInterface Helper { get; set; }
        public YAppReleaseManager AppReleaseManager { get; set; }

        public NewRelease()
        {
            InitializeComponent();
        }

        private void NewRelease_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} Updates", Helper.GetAppName());
            this.CenterToScreen();
            release = AppReleaseManager.CheckLatestRelease();
            if (release == null) {
                buttonUpdate.Enabled = false;
                buttonIgnore.Enabled = false;
                buttonRemindeMe.Enabled = false;
                buttonRelease.Enabled = false;
                label1.Text = String.Format("{0} is up to date:", Helper.GetAppName());
                labelNewVersion.Text = Helper.GetVersion();
                labelVersion.Text = "Current version:";
                labelLinkDecoration.Visible = false;
                linkLabel.Visible = false;
            } else {
                label1.Text = String.Format("Updates are available for the {0}:", Helper.GetAppName());
                buttonUpdate.Enabled = true;
                buttonIgnore.Enabled = true;
                buttonRemindeMe.Enabled = true;
                linkLabel.Text = release.link;
                labelNewVersion.Text = AppReleaseManager.FormatVersion(release.version);
            }

            checkUpdate.Checked = Helper.GetCheckUpdateSettings();
        }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(release.link);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (release.link.EndsWith(".msi")) {
                string downloadInstaller = AppReleaseManager.DownloadInstaller(release.link);
                Helper.StopRunningProcess();
                System.Diagnostics.Process.Start(downloadInstaller);
            } else {
                System.Diagnostics.Process.Start(release.link);
            }
            System.Windows.Forms.Application.Exit();
        }

        private void buttonRelease_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(AppReleaseManager.GetReleaseNotes());
        }

        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            Helper.SetBuildNumberToIgnoreSettings(release.version);
            this.Close();
        }

        private void checkUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Helper.SetCheckUpdateSettings(checkUpdate.Checked);
        }

        private void buttonRemindeMe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}