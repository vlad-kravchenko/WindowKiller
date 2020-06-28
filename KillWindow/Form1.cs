using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KillWindow
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void CloseWindow()
        {
            if (String.IsNullOrEmpty(windowName.Text)) return;
            IntPtr windowPtr = FindWindowByCaption(IntPtr.Zero, windowName.Text);
            if (windowPtr == IntPtr.Zero)
            {
                MessageBox.Show("Window not found");
                return;
            }

            SendMessage(windowPtr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            windowsList.Items.Clear();
            var pList = Process.GetProcesses();

            foreach (var process in pList)
            {
                if (process.MainWindowTitle != "") windowsList.Items.Add(process.MainWindowTitle);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void windowsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (windowsList.SelectedIndex < 0)
            {
                windowName.Text = "";
                return;
            }

            windowName.Text = windowsList.Items[windowsList.SelectedIndex].ToString();
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            windowsList.Enabled = !cbAuto.Checked;
            windowName.Enabled = !cbAuto.Checked;
            timer1.Enabled = cbAuto.Checked;
        }
    }
}
