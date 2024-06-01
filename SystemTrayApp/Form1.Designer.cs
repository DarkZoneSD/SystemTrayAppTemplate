namespace SystemTrayApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            openToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnCloseApp = new Button();
            btnMinimizeApp = new Button();
            btnSettings = new Button();
            pnlDragAndDrop = new Panel();
            lblAppName = new Label();
            pbAppIcon = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            pnlDragAndDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "SystemTrayApp";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.BackColor = Color.DimGray;
            btnCloseApp.BackgroundImage = Properties.Resources.exit_button_untriggered;
            btnCloseApp.BackgroundImageLayout = ImageLayout.Center;
            btnCloseApp.Location = new Point(740, 0);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(60, 40);
            btnCloseApp.TabIndex = 1;
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += btnCloseApp_Click;
            // 
            // btnMinimizeApp
            // 
            btnMinimizeApp.BackColor = Color.Transparent;
            btnMinimizeApp.BackgroundImage = Properties.Resources.minimize_button_untriggered;
            btnMinimizeApp.BackgroundImageLayout = ImageLayout.Center;
            btnMinimizeApp.Location = new Point(680, 0);
            btnMinimizeApp.Name = "btnMinimizeApp";
            btnMinimizeApp.Size = new Size(60, 40);
            btnMinimizeApp.TabIndex = 2;
            btnMinimizeApp.UseVisualStyleBackColor = false;
            btnMinimizeApp.Click += btnMinimizeApp_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.BackgroundImage = Properties.Resources.settings_button_untriggered;
            btnSettings.BackgroundImageLayout = ImageLayout.Center;
            btnSettings.Location = new Point(7, 571);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(42, 42);
            btnSettings.TabIndex = 3;
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // pnlDragAndDrop
            // 
            pnlDragAndDrop.BackColor = Color.Transparent;
            pnlDragAndDrop.Controls.Add(pbAppIcon);
            pnlDragAndDrop.Controls.Add(lblAppName);
            pnlDragAndDrop.Location = new Point(0, 0);
            pnlDragAndDrop.Name = "pnlDragAndDrop";
            pnlDragAndDrop.Size = new Size(680, 40);
            pnlDragAndDrop.TabIndex = 4;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppName.ForeColor = SystemColors.ControlLight;
            lblAppName.Location = new Point(56, 13);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(93, 15);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "SystemTrayApp";
            // 
            // pbAppIcon
            // 
            pbAppIcon.BackgroundImage = Properties.Resources.icon_32_32;
            pbAppIcon.BackgroundImageLayout = ImageLayout.Center;
            pbAppIcon.Location = new Point(12, 8);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(32, 32);
            pbAppIcon.TabIndex = 5;
            pbAppIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImage = Properties.Resources.background_ui;
            ClientSize = new Size(800, 625);
            Controls.Add(pnlDragAndDrop);
            Controls.Add(btnSettings);
            Controls.Add(btnMinimizeApp);
            Controls.Add(btnCloseApp);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemTrayApp";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            pnlDragAndDrop.ResumeLayout(false);
            pnlDragAndDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnCloseApp;
        private Button btnMinimizeApp;
        private Button btnSettings;
        private Panel pnlDragAndDrop;
        private Label lblAppName;
        private PictureBox pbAppIcon;
    }
}
