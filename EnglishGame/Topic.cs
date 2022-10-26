using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace EnglishGame
{
    public partial class Topic : Form
    {

        public WindowsMediaPlayer player;
        public Topic()
        {
            InitializeComponent();
        }

        public Topic(WindowsMediaPlayer play)
        {
            InitializeComponent();
            player = play;
          
        }

        public void callFromChild()
        {
            if (Global.SoundCheck)
            {
                player.controls.play();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to close the app?",
                                     "Notification",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void fruit_topic_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            var fruit = new Fruit();
            fruit.Owner = this;
            fruit.Show();
            //this.Hide();
        }
        private void animal_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            var animal = new Animal();
            animal.Owner = this;
            animal.Show();
            //this.Hide();
        }

        private void clothes_Click(object sender, EventArgs e)
        {

            player.controls.pause();
            var clothes = new Clothes();
            clothes.Owner = this;
            clothes.Show();
            //this.Hide();
        }


        private void device_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            var device = new Device();
            device.Owner = this;
            device.Show();
            //this.Hide();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = (Home)this.Owner;
            home.callFromChild();
            this.Owner.Show();
            this.Close();
        }

        private void Topic_Load(object sender, EventArgs e)
        {

        }
    }
}
