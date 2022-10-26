using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishGame
{
    public partial class Rank : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];
        public Rank()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
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

        private void Rank_Load(object sender, EventArgs e)
        {
            List<Data> listData = HandleFile.ReadFile(path);
            if (listData != null)
            {

                List<Data> listData_OrderBy = listData.OrderByDescending(x => x.point).ThenBy(x => x.hour).ThenBy(x => x.minute).ThenBy(x => x.second).ToList();

                if (listData_OrderBy.Count > 0)
                {
                    point_1.Text = "Point: " + listData_OrderBy.ElementAt(0).point.ToString();
                    time_1.Text = "Time: " + listData_OrderBy.ElementAt(0).hour.ToString() + ":" + listData_OrderBy.ElementAt(0).minute.ToString() + ":" + listData_OrderBy.ElementAt(0).second.ToString();
                    topic_1.Text = "Topic: " + listData_OrderBy.ElementAt(0).topic;

                }
                if (listData_OrderBy.Count > 1)
                {
                    point_2.Text = "Point: " + listData_OrderBy.ElementAt(1).point.ToString();
                    time_2.Text = "Time: " + listData_OrderBy.ElementAt(1).hour.ToString() + ":" + listData_OrderBy.ElementAt(1).minute.ToString() + ":" + listData_OrderBy.ElementAt(1).second.ToString();
                    topic_2.Text = "Topic: " + listData_OrderBy.ElementAt(1).topic;
                }
                if (listData_OrderBy.Count > 2)
                {
                    point_3.Text = "Point: " + listData_OrderBy.ElementAt(2).point.ToString();
                    time_3.Text = "Time: " + listData_OrderBy.ElementAt(2).hour.ToString() + ":" + listData_OrderBy.ElementAt(2).minute.ToString() + ":" + listData_OrderBy.ElementAt(2).second.ToString();
                    topic_3.Text = "Topic: " + listData_OrderBy.ElementAt(2).topic;
                }
                if (listData_OrderBy.Count > 3)
                {
                    point_4.Text = "Point: " + listData_OrderBy.ElementAt(3).point.ToString();
                    time_4.Text = "Time: " + listData_OrderBy.ElementAt(3).hour.ToString() + ":" + listData_OrderBy.ElementAt(3).minute.ToString() + ":" + listData_OrderBy.ElementAt(3).second.ToString();
                    topic_4.Text = "Topic: " + listData_OrderBy.ElementAt(3).topic;
                }
                if (listData_OrderBy.Count > 4)
                {
                    point_5.Text = "Point: " + listData_OrderBy.ElementAt(4).point.ToString();
                    time_5.Text = "Time: " + listData_OrderBy.ElementAt(4).hour.ToString() + ":" + listData_OrderBy.ElementAt(4).minute.ToString() + ":" + listData_OrderBy.ElementAt(4).second.ToString();
                    topic_5.Text = "Topic: " + listData_OrderBy.ElementAt(4).topic;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete data?",
                         "Notification",
                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                HandleFile.DeleteData(path);
                point_1.Text = "";
                point_2.Text = "";
                point_3.Text = "";
                point_4.Text = "";
                point_5.Text = "";

                time_1.Text = "";
                time_2.Text = "";
                time_3.Text = "";
                time_4.Text = "";
                time_5.Text = "";


                topic_1.Text = "";
                topic_2.Text = "";
                topic_3.Text = "";
                topic_4.Text = "";
                topic_5.Text = "";
            }

           

        }
    }
}
