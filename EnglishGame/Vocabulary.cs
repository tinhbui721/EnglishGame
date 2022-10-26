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
    public partial class Vocabulary : Form
    {
        public static string[] s = { "\\bin" };
        public static string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0];

        public Vocabulary()
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

        private void Vocabulary_Load(object sender, EventArgs e)
        {
            fruit.BackgroundImage = Image.FromFile(path + "\\Resources\\fruit_active.png");
            //Fruit
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("No", typeof(int));
            dt1.Columns.Add("English", typeof(string));
            dt1.Columns.Add("Vietnamese", typeof(string));
            dt1.Columns.Add("Image", typeof(Image));

            dt1.Rows.Add("1", "Banana", "Trái chuối", Image.FromFile(path + "\\Resources\\Fruit\\banana_small.png"));
            dt1.Rows.Add("2", "Apple", "Trái táo", Image.FromFile(path + "\\Resources\\Fruit\\apple_small.png"));
            dt1.Rows.Add("3", "Coconut", "Trái dừa", Image.FromFile(path + "\\Resources\\Fruit\\coconut_small.png"));
            dt1.Rows.Add("4", "Dragon Fruit", "Quả thanh long", Image.FromFile(path + "\\Resources\\Fruit\\dragon_fruit_small.png"));
            dt1.Rows.Add("5", "Durian", "Quả sầu riêng", Image.FromFile(path + "\\Resources\\Fruit\\durian_small.png"));
            dt1.Rows.Add("6", "Grape fruit", "Quả bưởi", Image.FromFile(path + "\\Resources\\Fruit\\grape_fruit_small.png"));
            dt1.Rows.Add("7", "Grape", "Trái nho", Image.FromFile(path + "\\Resources\\Fruit\\grape_small.png"));
            dt1.Rows.Add("8", "Guava", "Trái ổi", Image.FromFile(path + "\\Resources\\Fruit\\guava_small.png"));
            dt1.Rows.Add("9", "Melon", "Dưa gang, Dưa lưới", Image.FromFile(path + "\\Resources\\Fruit\\melon_small.png"));
            dt1.Rows.Add("10", "Orange", "Quả cam", Image.FromFile(path + "\\Resources\\Fruit\\orange_small.png"));
            dt1.Rows.Add("11", "Strawberry", "Trái dâu tây", Image.FromFile(path + "\\Resources\\Fruit\\strawberry_small.png"));
            dt1.Rows.Add("12", "Watermelon", "Quả dưa hấu", Image.FromFile(path + "\\Resources\\Fruit\\watermelon_small.png"));

            FruitModel.DataSource = dt1;
            FruitModel.Columns[0].Width = 50;
            FruitModel.Columns[1].Width = 165;
            FruitModel.Columns[2].Width = 170;
            FruitModel.Columns[3].Width = 160;

            //Animal
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("No", typeof(int));
            dt2.Columns.Add("English", typeof(string));
            dt2.Columns.Add("Vietnamese", typeof(string));
            dt2.Columns.Add("Image", typeof(Image));

            dt2.Rows.Add("1", "Lion", "Con Sư tử", Image.FromFile(path + "\\Resources\\Animal\\lion_small.png"));
            dt2.Rows.Add("2", "Cat", "Con Mèo", Image.FromFile(path + "\\Resources\\Animal\\cat_small.png"));
            dt2.Rows.Add("3", "Dog", "Con Chó", Image.FromFile(path + "\\Resources\\Animal\\dog_small.png"));
            dt2.Rows.Add("4", "Fox", "Con Cáo", Image.FromFile(path + "\\Resources\\Animal\\fox_small.png"));
            dt2.Rows.Add("5", "Giraffe", "Hươu Cao Cổ", Image.FromFile(path + "\\Resources\\Animal\\giraffe_small.png"));
            dt2.Rows.Add("6", "Horse", "Con Ngựa", Image.FromFile(path + "\\Resources\\Animal\\horse_small.png"));
            dt2.Rows.Add("7", "Leopard", "Con Báo Đớm", Image.FromFile(path + "\\Resources\\Animal\\leopard_small.png"));
            dt2.Rows.Add("8", "Monkey", "Con Khỉ", Image.FromFile(path + "\\Resources\\Animal\\monkey_small.png"));
            dt2.Rows.Add("9", "Rabbit", "Con Thỏ", Image.FromFile(path + "\\Resources\\Animal\\rabbit_small.png"));
            dt2.Rows.Add("10", "Rhino", "Con Tê Giác", Image.FromFile(path + "\\Resources\\Animal\\rhino_small.png"));
            dt2.Rows.Add("11", "Squirrel", "Con Sóc", Image.FromFile(path + "\\Resources\\Animal\\squirrel_small.png"));
            dt2.Rows.Add("12", "Tiger", "Con Hổ", Image.FromFile(path + "\\Resources\\Animal\\tiger_small.png"));

            AnimalModel.DataSource = dt2;
            AnimalModel.Columns[0].Width = 50;
            AnimalModel.Columns[1].Width = 165;
            AnimalModel.Columns[2].Width = 170;
            AnimalModel.Columns[3].Width = 160;

            //Clothes
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("No", typeof(int));
            dt3.Columns.Add("English", typeof(string));
            dt3.Columns.Add("Vietnamese", typeof(string));
            dt3.Columns.Add("Image", typeof(Image));

            dt3.Rows.Add("1", "Cap", "Mũ lưỡi trai", Image.FromFile(path + "\\Resources\\Clothes\\cap_small.png"));
            dt3.Rows.Add("2", "Dress", "Đầm", Image.FromFile(path + "\\Resources\\Clothes\\dress_small.png"));
            dt3.Rows.Add("3", "Dressing gown", "Áo choàng", Image.FromFile(path + "\\Resources\\Clothes\\dressing_gown_small.png"));
            dt3.Rows.Add("4", "Jacket", "Áo khoác", Image.FromFile(path + "\\Resources\\Clothes\\jacket_small.png"));
            dt3.Rows.Add("5", "Jeans", "Quần jean", Image.FromFile(path + "\\Resources\\Clothes\\jeans_small.png"));
            dt3.Rows.Add("6", "Jumper", "Áo len", Image.FromFile(path + "\\Resources\\Clothes\\jumper_small.png"));
            dt3.Rows.Add("7", "Pyjamas", "Đồ ngủ", Image.FromFile(path + "\\Resources\\Clothes\\pyjamas_small.png"));
            dt3.Rows.Add("8", "Raincoat", "Áo mưa", Image.FromFile(path + "\\Resources\\Clothes\\raincoat_small.png"));
            dt3.Rows.Add("9", "Skirt", "Váy", Image.FromFile(path + "\\Resources\\Clothes\\skirt_small.png"));
            dt3.Rows.Add("10", "Sneakers", "Giày thể thao", Image.FromFile(path + "\\Resources\\Clothes\\sneakers_small.png"));
            dt3.Rows.Add("11", "Socks", "Tất", Image.FromFile(path + "\\Resources\\Clothes\\socks_small.png"));
            dt3.Rows.Add("12", "T shirt", "Áo thun", Image.FromFile(path + "\\Resources\\Clothes\\t_shirt_small.png"));

            ClothesModel.DataSource = dt3;
            ClothesModel.Columns[0].Width = 50;
            ClothesModel.Columns[1].Width = 165;
            ClothesModel.Columns[2].Width = 170;
            ClothesModel.Columns[3].Width = 160;

            //Device
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("No", typeof(int));
            dt4.Columns.Add("English", typeof(string));
            dt4.Columns.Add("Vietnamese", typeof(string));
            dt4.Columns.Add("Image", typeof(Image));

            dt4.Rows.Add("1", "Laptop", "Máy tính xách tay", Image.FromFile(path + "\\Resources\\Device\\laptop_small.png"));
            dt4.Rows.Add("2", "Camera", "Máy ảnh", Image.FromFile(path + "\\Resources\\Device\\camera_small.png"));
            dt4.Rows.Add("3", "Clock", "Đồng hồ treo tường", Image.FromFile(path + "\\Resources\\Device\\clock_small.png"));
            dt4.Rows.Add("4", "Computer", "Máy tính", Image.FromFile(path + "\\Resources\\Device\\computer_small.png"));
            dt4.Rows.Add("5", "Fan", "Máy quạt", Image.FromFile(path + "\\Resources\\Device\\fan_small.png"));
            dt4.Rows.Add("6", "Head phone", "Tai nghe", Image.FromFile(path + "\\Resources\\Device\\head_phone_small.png"));
            dt4.Rows.Add("7", "Mobile phone", "Điện thoại di động", Image.FromFile(path + "\\Resources\\Device\\mobile_phone_small.png"));
            dt4.Rows.Add("8", "Printer", "Máy in", Image.FromFile(path + "\\Resources\\Device\\printer_small.png"));
            dt4.Rows.Add("9", "Projector", "Máy chiếu", Image.FromFile(path + "\\Resources\\Device\\projector_small.png"));
            dt4.Rows.Add("10", "Scanner", "Máy quét", Image.FromFile(path + "\\Resources\\Device\\scanner_small.png"));
            dt4.Rows.Add("11", "Speaker", "Loa", Image.FromFile(path + "\\Resources\\Device\\speaker_small.png"));
            dt4.Rows.Add("12", "Watch", "Đồng hồ đeo tay", Image.FromFile(path + "\\Resources\\Device\\watch_small.png"));

            DeviceModel.DataSource = dt4;
            DeviceModel.Columns[0].Width = 50;
            DeviceModel.Columns[1].Width = 165;
            DeviceModel.Columns[2].Width = 170;
            DeviceModel.Columns[3].Width = 160;

            AnimalModel.Visible = false;
            ClothesModel.Visible = false;
            DeviceModel.Visible = false;
        }

        private void reset()
        {
            fruit.BackgroundImage = Image.FromFile(path + "\\Resources\\fruit.png");
            animal.BackgroundImage = Image.FromFile(path + "\\Resources\\animal.png");
            clothes.BackgroundImage = Image.FromFile(path + "\\Resources\\clothes.png");
            device.BackgroundImage = Image.FromFile(path + "\\Resources\\device_1.png");
            FruitModel.Visible = false;
            AnimalModel.Visible = false;
            ClothesModel.Visible = false;
            DeviceModel.Visible = false;


        }

        private void fruit_Click(object sender, EventArgs e)
        {
            this.reset();
            fruit.BackgroundImage = Image.FromFile(path + "\\Resources\\fruit_active.png");

            FruitModel.Visible = true;
        }

        private void animal_Click(object sender, EventArgs e)
        {
            this.reset();
            animal.BackgroundImage = Image.FromFile(path + "\\Resources\\animal_active.png");
            AnimalModel.Visible = true;

        }

        private void clothes_Click(object sender, EventArgs e)
        {
            this.reset();
            clothes.BackgroundImage = Image.FromFile(path + "\\Resources\\clothes_active.png");
            ClothesModel.Visible = true;

        }

        private void device_Click(object sender, EventArgs e)
        {
            this.reset();
            device.BackgroundImage = Image.FromFile(path + "\\Resources\\device_active.png");
            DeviceModel.Visible = true;

        }
    }
}
