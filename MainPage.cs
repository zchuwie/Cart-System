using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCCFoodTrackerNeo
{
    public partial class MainPage : Form
    {
        // Fields
        private int borderSize = 2;
        private Size formSize;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize); // For border size
            this.BackColor = Color.FromArgb(65, 100, 74); // For border color
        }
        #region - METHODS -
        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) // Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                menuBtn.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { // Expand menu
                panelMenu.Width = 243;
                pictureBox1.Visible = true;
                menuBtn.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        #endregion

        #region - CLICK EVENTS -
        private void menuBtn_Click(object sender, EventArgs e) // For menu collapse
        {
            CollapseMenu();
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) // For form dragging
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void labelTitleBar_MouseDown(object sender, MouseEventArgs e) // For form dragging
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void exitBtn_Click(object sender, EventArgs e) // For exit
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void homeBtn_Click(object sender, EventArgs e)
        {
            labelTitleBar.Text = "Hello, userName!";
            FoodPage f = new FoodPage();
            f.TopLevel = false;
            panelContent.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
  

        private void storesBtn_Click(object sender, EventArgs e)
        {
            labelTitleBar.Text = "Stores";
            StorePage s = new StorePage();
            s.TopLevel = false;
            panelContent.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void cartBtn_Click(object sender, EventArgs e)
        {
            labelTitleBar.Text = "Your Cart";
            CartPage c = new CartPage();
            c.TopLevel = false;
            panelContent.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }
        #endregion
    }
}
