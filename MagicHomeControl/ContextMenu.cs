using MagicHome;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicHomeControl
{
    public partial class ContextMenu : UserControl
    {
        public ContextMenu()
        {
            InitializeComponent();                        
            Task.Run(Init);
            timer1.Interval = Convert.ToInt32(TimeSpan.FromSeconds(5).TotalMilliseconds);
            timer1.Start();
        }

        private Light _light;
        private bool _initialized;
        async Task Init()
        {
            ledStripeToolStripMenuItem.Text = "Not found!";

            var ip = Properties.Settings.Default.IP;
            //ip = null;
            if (string.IsNullOrEmpty(ip))
            {                
                var discoveredLights = await Light.DiscoverAsync();
                _light = discoveredLights.SingleOrDefault();

                if (_light == null)
                    return;
            }
            else
            {
                _light = new Light(ip);
            }

            // Connect.
            await _light.ConnectAsync();            
            // Der 1.Connect kommt irgendwie nie zurück

            if (!_light.Connected)
                return;

            ledStripeToolStripMenuItem.Enabled = true;
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
            onOffToolStripMenuItem.Text = _light.Power ? "Turn Off" : "Turn On";
            onOffToolStripMenuItem.Image = _light.Power ? Properties.Resources.lightbulb : Properties.Resources.lightbulb_1_;
            brightnessToolStripMenuItem.Text = Convert.ToString(_light.WarmWhite);
            _initialized = true;
        }


        async Task RefreshLight()
        {
            // Refresh Values - geht nicht
            return;
            await _light.RefreshAsync();
        }

        private async void onOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_initialized) return;
            await RefreshLight();
            await _light.SetPowerAsync(!_light.Power);
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

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(System.Windows.Forms.Cursor.Position);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (_light == null || !_light.Connected)
            { 
                await Init();
                timer1.Interval = Convert.ToInt32(TimeSpan.FromMinutes(5).TotalMilliseconds);
            }
            else
            {
                await RefreshLight();
            }                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Refresh Connection
            if (_light != null && _light.Connected) return;
            await Init();
        }
    }
}
