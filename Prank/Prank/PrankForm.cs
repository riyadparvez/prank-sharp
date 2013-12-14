using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prank
{
    public partial class PrankForm : Form, IMessageFilter 
    {
        private bool shouldClose = false;
        private RegistryKey startup_key = 
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private KeyboardHook hook = new KeyboardHook();

        public PrankForm()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            this.FormClosed += (o, e) => Application.RemoveMessageFilter(this);
            this.AllowTransparency = true;
            this.KeyPreview = true;
            //startup_key.SetValue("prank-sharp", Application.ExecutablePath.ToString());
            //startup_key.DeleteValue("prank-sharp");
            // register the event that is fired after the key press.
            hook.KeyPressed += Exit;
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(Prank.ModifierKeys.Control | Prank.ModifierKeys.Alt, Keys.F);
        }

        private void KeepOnTop() 
        {
            /*
            // Repeat every 2 seconds.
            IObservable<long> observable = Observable.Interval(TimeSpan.FromSeconds(2));

            // Token for cancelation
            CancellationTokenSource source = new CancellationTokenSource();

            // Create task to execute.
            Action action = (() => Console.WriteLine("Action started at: {0}", DateTime.Now));
            Action resumeAction = (() => Console.WriteLine("Second action started at {0}", DateTime.Now));

            // Subscribe the obserable to the task on execution.
            observable.Subscribe(x =>
            {
                Task task = new Task(action); task.Start();
                task.ContinueWith(c => resumeAction());
            }, source.Token);
            */
        }

        private void Initialize() 
        {
 
        }

        private void PrankForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.Color;
            //this.Opacity = 100 - Properties.Settings.Default.Transparency;
        }

        public bool PreFilterMessage(ref Message m)
        {
            /*
            // Catch WM_KEYDOWN message
            if (m.Msg == 0x100 && (Keys)m.WParam == Keys.F1)
            {
                MessageBox.Show("Help me!");
                return true;
            }
            */
            return false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F)) 
            {
                shouldClose = true;
                return true;
            }
            //return base.ProcessCmdKey(ref msg, keyData);
            return true; // <- Stop processing the WM_KeyDown message 
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation<
        }

        private void PrankForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void PrankForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PrankForm_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void Exit(object sender, KeyPressedEventArgs e) 
        {
            Application.Exit();
        }

        private void PrankForm_Deactivate(object sender, EventArgs e)
        {
            //this.TopMost = true;
        }

        private void PrankForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!shouldClose)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                }
                shouldClose = false;
            }
        }
    }
}
