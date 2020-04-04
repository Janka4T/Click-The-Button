using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Click_The_Button
{
    
    public partial class ClickTheButton : Form
    {
        Random rand = new Random();
        private PictureBox zone;        
        int clicks = 0;
        bool on = true;
        bool off = true;

        public ClickTheButton()
        {
            InitializeComponent();
            InitializeGameBorder();
            UpdateClicks();
        }       

        private void buttonClick_Click(object sender, EventArgs e)
        {                                  
            buttonClick.Left = rand.Next(50, 350);
            buttonClick.Top = rand.Next(50, 350);           
            clicks++;
            UpdateClicks();            
        }
        private void InitializeGameBorder()
        {
            zone = new PictureBox();
            zone.Left = 50;
            zone.Top = 50;
            zone.Width = 350;
            zone.Height = 350;
            zone.BackColor = Color.White;
            this.Controls.Add(zone);
        }       

        private void UpdateClicks()
        {
            labelClicks.Text = "Click's: " + clicks.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();        
        }

        private void tinyModeToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            buttonClick.Width = 10;
            buttonClick.Height = 10;
            clicks = 0;
            UpdateClicks();
            
        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonClick.Width = 41;
            buttonClick.Height = 41;
            clicks = 0;
            UpdateClicks();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't Waste Your Time go CLICK!");
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkColor = Color.Gray;
            Color lightColor = Color.Black;
            buttonClick.BackColor = darkColor;
            buttonClick.ForeColor = lightColor;
            menuStrip1.BackColor = darkColor;
            menuStrip1.ForeColor = lightColor;
            this.BackColor = darkColor;
            this.ForeColor = lightColor;
            zone.BackColor = Color.LightGray;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color darkColor = Color.Black;
            Color lightColor = Color.WhiteSmoke;
            buttonClick.BackColor = lightColor;
            buttonClick.ForeColor = darkColor;
            menuStrip1.BackColor = lightColor;
            menuStrip1.ForeColor = darkColor;
            this.BackColor = lightColor;
            this.ForeColor = darkColor;
            zone.BackColor = Color.White;
        }

        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if(on == true)
            {
            buttonClick.Left = rand.Next(50, 350);
            buttonClick.Top = rand.Next(50, 350);
            buttonClick.Width = rand.Next(10, 41);
            buttonClick.Height = rand.Next(10, 41);
            }
           
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            off = false;
            if (off == false)
            {
                buttonClick.Width = 41;
                buttonClick.Height = 41;
            }
            else if (off == true)
            {
                on = true;
            }
        }
    }
}
