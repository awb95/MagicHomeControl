using MagicHome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicHomeControl
{
    public partial class ContextMenuForm : Form
    {
        public ContextMenuForm()
        {
            InitializeComponent();                        
            Task.Run(Init);
            Hide();
        }

        private Light _light;
        private bool _initialized;
        async Task Init()
        {
            ledStripeToolStripMenuItem.Text = "Not found!";
            var discoveredLights = await Light.DiscoverAsync();

            _light = discoveredLights.SingleOrDefault();
            if (_light == null) return;

            // Connect.
            await _light.ConnectAsync();

            if (!_light.Connected)
                return;

            ledStripeToolStripMenuItem.Text = "LED-Stripe";
            ledStripeToolStripMenuItem.Tag = _light;

            var values = new object[100];
            for (var i = 0; i < 100; i++)
                values[i] = Convert.ToString(i + 1);

            brightnessToolStripMenuItem.Items.AddRange(values.ToArray());

            await UpdateUI();
        }

        async Task UpdateUI()
        {
            _initialized = false;
            //await _light.RefreshAsync();
            onToolStripMenuItem.Enabled = !_light.Power;
            offToolStripMenuItem.Enabled = _light.Power;
            brightnessToolStripMenuItem.Text = Convert.ToString(_light.WarmWhite);
            _initialized = true;
        }


        async Task RefreshLight()
        {
            return;
            await _light.RefreshAsync();
        }

        private async void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_initialized) return;
            await RefreshLight();
            await _light.SetPowerAsync(true);
            await UpdateUI();
        }

        private async void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_initialized) return;
            await RefreshLight();
            await _light.SetPowerAsync(false);
            await UpdateUI();
        }

        private async void brightnessToolStripMenuItem_TextChanged(object sender, EventArgs e)
        {
            if (!_initialized) return;
            if (!byte.TryParse(brightnessToolStripMenuItem.Text, out var brightness)) return;
            await RefreshLight();
            await _light.SetWarmWhiteAsync(brightness);
            await UpdateUI();
        }

        private async void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_light == null) return;
            await _light.RefreshAsync();
        }

        private async void ledStripeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_light != null) return;
            await Init();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(System.Windows.Forms.Cursor.Position);
        }
    }
}
