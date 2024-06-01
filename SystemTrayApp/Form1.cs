using System;
using SystemTrayApp.Properties;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace SystemTrayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;
            this.SizeChanged += Form1_Resize;
            //Drag and Drop Form
            this.pnlDragAndDrop.MouseDown += new MouseEventHandler(DragAndDropMouseDown);
            this.lblAppName.MouseDown += new MouseEventHandler(DragAndDropMouseDown);
            this.pbAppIcon.MouseDown += new MouseEventHandler(DragAndDropMouseDown);

            //Menu Buttons
            btnCloseApp.MouseEnter += OnMouseEnterBtnCloseApp;
            btnCloseApp.MouseLeave += OnMouseLeaveBtnCloseApp;
            btnCloseApp.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnCloseApp.BackColorChanged += (s, e) =>
            {
                btnCloseApp.FlatAppearance.MouseOverBackColor = Color.DimGray;
            };

            btnMinimizeApp.MouseEnter += OnMouseEnterBtnMinimizeApp;
            btnMinimizeApp.MouseLeave += OnMouseLeaveBtnMinimizeApp;
            btnMinimizeApp.FlatAppearance.MouseOverBackColor = Color.DimGray;
            btnMinimizeApp.BackColorChanged += (s, e) =>
            {
                btnMinimizeApp.FlatAppearance.MouseOverBackColor = Color.DimGray;
            };

            btnSettings.MouseEnter += OnMouseEnterBtnSettings;
            btnSettings.MouseLeave += OnMouseLeaveBtnSettings;

        }

        //Drag and Drop Form
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void DragAndDropMouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
            }
        }

        //End Drag and Drop Form

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }
        //Exit Button
        private void OnMouseEnterBtnCloseApp(object sender, EventArgs e)
        {
            btnCloseApp.BackgroundImage = Resources.exit_button_triggered;
        }
        private void OnMouseLeaveBtnCloseApp(object sender, EventArgs e)
        {
            btnCloseApp.BackgroundImage = Resources.exit_button_untriggered;
        }
        //Minimize Button
        private void OnMouseEnterBtnMinimizeApp(object sender, EventArgs e)
        {
            btnMinimizeApp.BackgroundImage = Resources.minimize_button_triggered;
        }
        private void OnMouseLeaveBtnMinimizeApp(object sender, EventArgs e)
        {
            btnMinimizeApp.BackgroundImage = Resources.minimize_button_untriggered;
        }
        //Settings Button
        private void OnMouseEnterBtnSettings(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Resources.settings_button_triggered;
        }
        private void OnMouseLeaveBtnSettings(object sender, EventArgs e)
        {
            btnSettings.BackgroundImage = Resources.settings_button_untriggered;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            notifyIcon1.ContextMenuStrip.Visible = false;
            notifyIcon1.ContextMenuStrip.Close();
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;

            if (e.Button == MouseButtons.Left)
            {
                notifyIcon1.Visible = false;
                Show();
            }
            else if (e.Button == MouseButtons.Right)
            {
                notifyIcon1.ContextMenuStrip.Show(new Point(Cursor.Position.X + 1, Cursor.Position.Y + 1));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            btnCloseApp.TabStop = false;
            btnCloseApp.FlatStyle = FlatStyle.Flat;
            btnCloseApp.FlatAppearance.BorderSize = 0;
            btnCloseApp.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
            btnMinimizeApp.TabStop = false;
            btnMinimizeApp.FlatStyle = FlatStyle.Flat;
            btnMinimizeApp.FlatAppearance.BorderSize = 0;
            btnMinimizeApp.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
            btnSettings.TabStop = false;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //Transparent
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
