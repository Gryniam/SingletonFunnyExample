using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Televisor
{
    public partial class Form1 : Form
    {
        Televisor televisor;
        public Form1()
        {
            InitializeComponent();
            televisor = Televisor.getInstance();
        }

        #region
        Point lastpoint;
        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void headPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hideLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            teleBox.Image = Image.FromFile(Program.pathToFotos + "televisor.jpg");
            teleBox.SizeMode = PictureBoxSizeMode.Zoom;
            screenBox.SizeMode = PictureBoxSizeMode.Zoom;

            timer.Interval = 200;
            timer.Tick += new EventHandler(update);
            timer.Start();
            

        }
        void getPiture(ref PictureBox p)
        {
            try
            {
                p.Image = Image.FromFile(televisor.Channel.Path);
            }
            catch
            {
                try
                {
                    p.Image = Image.FromFile(Program.pathToErrorPhoto);
                }
                catch (Exception) { }
            }
        }

        private void update(object sender, EventArgs e)
        {
            if(televisor.Turn == true)
            {
                televisor.Channel = televisor.Channels[televisor.ChannelI];
                getPiture(ref screenBox);
                soundStatusLabel.Text = "Sound: "+ televisor.Sound.ToString();
                channelStatusLabel.Text = "Channel: " + televisor.Channel.Name;
            }
            else
            {
                try
                {
                    screenBox.Image = Image.FromFile(Program.blackScreen);
                }
                catch
                {
                    screenBox.Dispose();
                }

                soundStatusLabel.Text = "Sound: ";
                channelStatusLabel.Text = "Channel: ";
            }
           
            signalButton.BackColor = Color.Black;
        }

        private void tvOnPannel_Click(object sender, EventArgs e)
        {
            if(televisor.Turn == false)
            {
                televisor.Turn = true;
                signalButton.BackColor = Color.Red;
            }
            else
            {
                televisor.Turn = false;
            }
        }

        private void soundUpButton_Click(object sender, EventArgs e)
        {
            televisor.Sound++;
            signalButton.BackColor = Color.Red;
        }

        private void soundDownButton_Click(object sender, EventArgs e)
        {
            televisor.Sound--;
            signalButton.BackColor = Color.Red;
        }

        private void soundUpButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                televisor.Sound += 10;
            }
            signalButton.BackColor = Color.Red;
        }

        private void soundDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                televisor.Sound -= 10;
            }
            signalButton.BackColor = Color.Red;
        }

        private void channelRightButton_Click(object sender, EventArgs e)
        {
            televisor.ChannelI++;
            signalButton.BackColor = Color.Red;
        }

        private void channelLeftButton_Click(object sender, EventArgs e)
        {
            televisor.ChannelI--;
            signalButton.BackColor = Color.Red;
        }
    }
}
