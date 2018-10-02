using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekAkhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeControl1.BringToFront();
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = HomeButton.Height;
            SidePanel.Top = HomeButton.Top;
            homeControl1.BringToFront();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuButton.Height;
            SidePanel.Top = MenuButton.Top;
            menuControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            SidePanel.Height = MenuButton.Height;
            SidePanel.Top = MenuButton.Top;
            menuControl1.BringToFront();
        }
    }
}
