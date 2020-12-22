using System;
using System.Diagnostics;
using System.Windows.Forms;
using Impostor.Patcher.Shared;
using Impostor.Patcher.Shared.Events;

namespace Impostor.Patcher.WinForms.Forms
{
    public partial class FrmMain : Form
    {
        private readonly AmongUsModifier _modifier;

        public FrmMain()
        {
            InitializeComponent();

            AcceptButton = beta;

            _modifier = new AmongUsModifier();
            _modifier.Error += ModifierOnError;
            _modifier.Saved += ModifierOnSaved;
        }

        private void ModifierOnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show(e.Message, "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            stable.Enabled = true;
            beta.Enabled = true;
        }

        private void ModifierOnSaved(object sender, SavedEventArgs e)
        {
            MessageBox.Show("Zapisano! Proszę (ponownie) uruchom Among Us.", "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {

        }

        private async void buttonLaunch_Click(object sender, EventArgs e)
        {
            beta.Enabled = false;

            await _modifier.SaveIpAsync("");
        }

        private void lblUrl_Click(object sender, EventArgs e)
        {
            Process.Start("https://impostors.ga/");
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            stable.Enabled = false;

            await _modifier.SaveIpAsync("146.59.13.142:23023");
        }
    }
}
