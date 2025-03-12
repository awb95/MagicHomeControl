
namespace MagicHomeControl
{
    partial class ContextMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContextMenu));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ledStripeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Status";
            this.notifyIcon1.BalloonTipTitle = "LED-Stripe";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MagicHome";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledStripeToolStripMenuItem,
            this.refreshToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 70);
            // 
            // ledStripeToolStripMenuItem
            // 
            this.ledStripeToolStripMenuItem.AutoSize = false;
            this.ledStripeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onOffToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.ledStripeToolStripMenuItem.Enabled = false;
            this.ledStripeToolStripMenuItem.Image = global::MagicHomeControl.Properties.Resources.lightbulb;
            this.ledStripeToolStripMenuItem.Name = "ledStripeToolStripMenuItem";
            this.ledStripeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ledStripeToolStripMenuItem.Text = "LED-Stripe";
            // 
            // onOffToolStripMenuItem
            // 
            this.onOffToolStripMenuItem.AutoSize = false;
            this.onOffToolStripMenuItem.Image = global::MagicHomeControl.Properties.Resources.lightbulb;
            this.onOffToolStripMenuItem.Name = "onOffToolStripMenuItem";
            this.onOffToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.onOffToolStripMenuItem.Text = "On / Off";
            this.onOffToolStripMenuItem.Click += new System.EventHandler(this.onOffToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.AutoSize = false;
            this.brightnessToolStripMenuItem.DropDownHeight = 23;
            this.brightnessToolStripMenuItem.IntegralHeight = false;
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.brightnessToolStripMenuItem.TextChanged += new System.EventHandler(this.brightnessToolStripMenuItem_TextChanged);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.AutoSize = false;
            this.refreshToolStripMenuItem.Image = global::MagicHomeControl.Properties.Resources.loading_arrow;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Image = global::MagicHomeControl.Properties.Resources.loading_arrow;
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MagicHomeControl.Properties.Resources.no;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContextMenu
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "ContextMenu";
            this.Size = new System.Drawing.Size(284, 261);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ledStripeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
    }
}

