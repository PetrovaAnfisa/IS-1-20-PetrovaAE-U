using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_PetrovaAE_U
{
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }
        public abstract class Complectation<T>
        {
            public int Price;
            public int Year_of_issue;
            public T Article;


            public Complectation(int price, int year_of_issue, T article)
            {
                this.Price = price;
                this.Year_of_issue = year_of_issue;
                this.Article = article;
            }
            public void Display()
            {
                MessageBox.Show($"цена{Price}, год выпуска{Year_of_issue}, артикул{Article}");
            }
            class Harddrives<T> : Complectation<T>
            {
                public int number_of_Turns;
                public string InterFace;
                public int voiume;


                public Harddrives(int number_of_Turns, string InterFace, int voiume, int price, int year_of_issue, T article) : base(price, year_of_issue, article)
                {
                    this.number_of_Turns = number_of_Turns;
                    this.InterFace = InterFace;
                    this.voiume = voiume;
                }
                public void newDisplay()
                {
                    MessageBox.Show($"Колличество оборотов{number_of_Turns}, интерфейс{InterFace}, объем{voiume}, цена{Price}, год выпуска{Year_of_issue}, артикул{Article}");
                }
            }
            class Videoscard<T> : Complectation<string>
            {
                public int gpu_frequency;
                public string manufacturer;
                public int memory_size;

                public Videoscard(int Price, int Year_of_issue, int gpu_frequency, string Article,string manufacturer, int memory_size) : base(Price, Year_of_issue, Article)
                {
                    this.gpu_frequency = gpu_frequency;
                    this.manufacturer = manufacturer;
                    this.memory_size = memory_size;
                }
                public new void Dicplay()
                {
                    MessageBox.Show($"цена{Price}, год выпуска{Year_of_issue}, артикул {Article}, частота{gpu_frequency},изготовитель {manufacturer}, Объем памяти{memory_size}");
                }
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }

        private void Accessories_Load(object sender, EventArgs e)
        {

        }
        Harddrive Harddrive;
        VideoCard gpu;

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox1.Clear();
            ListBox1Items.Ad($"Кол-во оборотов {textBox1.Text}");
            ListBox1Items.Ad($"Интерфейс {textBox2.Text}");
            ListBox1Items.Ad($"Артикул {textBox3.Text}");
            ListBox1Items.Ad($"Объем {textBox4.Text}");
            ListBox1Items.Ad($"Цена {textBox5.Text}");
            ListBox1Items.Ad($"Год {textBox6.Text}");
            Harddrive = new Harddrive(Convert.ToInt32(textBox1.Text), textBox2.Text,
                textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            Harddrive.Display();

        }
    }
}

