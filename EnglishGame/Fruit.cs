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
    public partial class Fruit : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
        public string[] fruits = { "apple", "banana", "coconut", "dragon fruit", "durian", "grape", "grape fruit", "guava", "melon", "orange", "strawberry", "watermelon" };
        public int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        public int[] randomValue;
        public int pointCount = 0;
        public string[] userAnswer = new string[10];
        public bool[] checkUserAnswer = new bool[10];
        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        public WindowsMediaPlayer player_parent;
        public int countSubmit = 0;


        private DateTime StartTime = DateTime.Now;

        public Fruit()
        {
            InitializeComponent();
        }

        public Fruit(WindowsMediaPlayer play)
        {
            InitializeComponent();
            player_parent = play;
        }
        private int[] GetRandom(int[] array)
        {
            Random rand = new Random();
            int[] arrResult = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrResult[i] = array[rand.Next(array.Length)];
                array = array.Where(x => x != arrResult[i]).ToArray();
            }

            return arrResult;
        }

        private void showAnswer()
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("No", typeof(int));
            dt2.Columns.Add("Correct answer", typeof(string));
            dt2.Columns.Add("Your answer", typeof(string));
            dt2.Columns.Add("Result", typeof(Image));
            dt2.Columns.Add("Image", typeof(Image));

            for (int i = 0; i < 10; i++)
            {
                dt2.Rows.Add(i + 1, fruits[randomValue[i]], userAnswer[i], Image.FromFile(path + "\\Resources\\" + checkUserAnswer[i] + ".png"), Image.FromFile(path + "\\Resources\\Fruit\\" + fruits[randomValue[i]].Replace(" ", "_") + "_small.png"));
            }
            resultTable.DataSource = dt2;
            resultTable.Columns[0].Width = 45;
            resultTable.Columns[1].Width = 145;
            resultTable.Columns[2].Width = 145;
            resultTable.Columns[3].Width = 50;
            resultTable.Columns[4].Width = 160;
        }

        private void back_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Topic topic = (Topic)this.Owner;
            topic.callFromChild();
            this.Owner.Show();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            Home home = (Home)this.Owner.Owner;
            home.callFromChild();
            this.Owner.Owner.Show();
            this.Owner.Close();
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

        private void button_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "" && textBox.Text != null)
            {
                userAnswer[countSubmit] = textBox.Text;
                checkUserAnswer[countSubmit] = false;

                if (textBox.Text.ToLower() == fruits[randomValue[countSubmit]])
                {
                    Global.correctSound();
                    checkUserAnswer[countSubmit] = true;
                    pointCount = pointCount + 10;
                }
                else
                {
                    Global.wrongSound();
                }
                point.Text = pointCount.ToString() + "/100";
                if (countSubmit < 9)
                {
                    countSubmit++;
                    question.Text = (countSubmit + 1).ToString() + "/10";
                    pictureBox.BackgroundImage = Image.FromFile(path + "\\Resources\\Fruit\\" + fruits[randomValue[countSubmit]].Replace(" ", "_") + ".png");
                }
                else
                {
                    pictureBox.BackgroundImage = Image.FromFile(path + "\\Resources\\finish.png");
                    textBox.Enabled = false;
                    button.Enabled = false;
                    button.Visible = false;
                    answer.Visible = true;
                    timer1.Enabled = false;
                    string data = point.Text.Split('/')[0] + ";" + time.Text + ";" + "fruit";
                    HandleFile.SaveFile(data, path);
                }
                textBox.Clear();
                textBox.Focus();
            }
        }

        private void Fruit_Load(object sender, EventArgs e)
        {
            resultTable.Visible = false;
            randomValue = GetRandom(arr);
            point.Text = pointCount.ToString() + "/100";
            question.Text = (countSubmit + 1).ToString() + "/10";
            pictureBox.BackgroundImage = Image.FromFile(path + "\\Resources\\Fruit\\" + fruits[randomValue[0]].Replace(" ", "_") + ".png");
            player.URL = "music_kid.mp3";
            player.settings.setMode("loop", true);
            player.settings.volume = 40;
            if (!Global.SoundCheck)
            {
                sound.BackgroundImage = Image.FromFile(path + "\\Resources\\sound_off.png");
                player.controls.stop();
            }
        }

        private void answer_Click(object sender, EventArgs e)
        {
            showAnswer();
            resultTable.Visible = true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox.Text = textBox.Text.TrimEnd('\r', '\n');

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox.Text != "" && textBox.Text != null)
                {
                    userAnswer[countSubmit] = textBox.Text;
                    checkUserAnswer[countSubmit] = false;

                    if (textBox.Text.ToLower() == fruits[randomValue[countSubmit]])
                    {
                        Global.correctSound();
                        pointCount = pointCount + 10;
                        checkUserAnswer[countSubmit] = true;
                    }
                    else
                    {
                        Global.wrongSound();
                    }
                    point.Text = pointCount.ToString() + "/100";
                    if (countSubmit < 9)
                    {
                        countSubmit++;
                        question.Text = (countSubmit + 1).ToString() + "/10";
                        pictureBox.BackgroundImage = Image.FromFile(path + "\\Resources\\Fruit\\" + fruits[randomValue[countSubmit]].Replace(" ", "_") + ".png");
                    }
                    else
                    {
                        pictureBox.BackgroundImage = Image.FromFile(path + "\\Resources\\finish.png");
                        textBox.Enabled = false;
                        button.Enabled = false;
                        button.Visible = false;
                        answer.Visible = true;
                        timer1.Enabled = false;
                        string data = point.Text.Split('/')[0] + ";" + time.Text + ";" + "fruit";
                        HandleFile.SaveFile(data, path);
                    }
                }
                textBox.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds;

            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00");

            time.Text = text;
        }


    }
}
