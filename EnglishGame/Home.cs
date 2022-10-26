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
    public partial class Home : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
        public WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Home()
        {
            InitializeComponent();
            player.URL = "music_background.mp3";
            player.settings.setMode("loop", true);

        }

        public void callFromChild()
        {
            if (Global.SoundCheck)
            {
                player.controls.play();
                sound.BackgroundImage = Image.FromFile(path + "\\Resources\\sound_on.png");
            }
            else
            {
                sound.BackgroundImage = Image.FromFile(path + "\\Resources\\sound_off.png");
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
        private void vocab_Click(object sender, EventArgs e)
        {
            var vocab = new Vocabulary();
            vocab.Owner = this;
            vocab.Show();
            this.Hide();

        }

        private void start_Click(object sender, EventArgs e)
        {
            var topic = new Topic(player);
            topic.Owner = this;
            topic.Show();
            //this.Hide();
        }

        private void Rank_Click(object sender, EventArgs e)
        {
            var rank = new Rank();
            rank.Owner = this;
            rank.Show();
            this.Hide();
        }

        private void sound_Click(object sender, EventArgs e)
        {
            if (Global.SoundCheck)
            {
                sound.BackgroundImage = Image.FromFile(path + "\\Resources\\sound_off.png");
                player.controls.pause();
            }
            else
            {
                sound.BackgroundImage = Image.FromFile(path + "\\Resources\\sound_on.png");
                player.controls.play();

            }
            Global.SoundCheck = !Global.SoundCheck;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
