using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prank
{
    public partial class PrankForm : Form
    {
        private RegistryKey startup_key = 
            Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private KeyboardHook hook = new KeyboardHook();

        public PrankForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            startup_key.SetValue("prank-sharp", Application.ExecutablePath.ToString());
            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(Exit);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(Prank.ModifierKeys.Control | Prank.ModifierKeys.Alt, Keys.F12);
        }

        private void PrankForm_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
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
    }
}
