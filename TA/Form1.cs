using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //  Тут создаем картинку, на которой будет рисовать
            Image img = new Bitmap(1024, 512);

            //  Установим эту картинку в pictureBox, который на экране
            pictureBoxMap.Image = img;

            //  Создаем штуку, которая будет рисовать
            Graphics g = Graphics.FromImage(img);

            //  Чем рисовать. Сделаем и для дороги, и для городов свои карандаши
            Pen penRoad = new Pen(Color.Blue, 3);
            Pen penCity = new Pen(Color.Blue, 5);  //Для городов чуть толще
            
            //  Дальше просто нарисую карту эту, потом объясню)) А то долго что-то
            StreamReader reader = new StreamReader("input.txt");
            string[] s = reader.ReadLine().Split();
            int w = Convert.ToInt32(s[0]);
            int h = Convert.ToInt32(s[1]);

            int n = Convert.ToInt32(reader.ReadLine());
            List<Point> Cities = new List<Point>();
            List<string> CitiesName = new List<string>();
            for (int i = 0; i < n; i++)
            {

                s = reader.ReadLine().Split();
                int _x = Convert.ToInt32(s[1]);
                int _y = Convert.ToInt32(s[2]);
                Point city = new Point(_x, _y);
                Cities.Add(city);
                CitiesName.Add(s[0]);
            }

            int m = Convert.ToInt32(reader.ReadLine());
            List<Road> Roads = new List<Road>();
            for (int i = 0; i < m; i++)
            {
                s = reader.ReadLine().Split();
                int a = Convert.ToInt32(s[0]);
                int b = Convert.ToInt32(s[1]);
                Road road = new Road(a, b);
                Roads.Add(road);
            }

            //  тут надо еще будет водителей принять)
            n = Convert.ToInt32(reader.ReadLine());
            dataDriver.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                string[] str = reader.ReadLine().Split();
                dataDriver.Rows[i].Cells[0].Value = str[0];
                dataDriver.Rows[i].Cells[1].Value = str[1];
                dataDriver.Rows[i].Cells[2].Value = str[2];
                dataDriver.Rows[i].Cells[3].Value = str[3];
                dataDriver.Rows[i].Cells[4].Value = str[4];


            }
            reader.Close();

            //  Перебираем дороги и рисуем их
            for (int i = 0; i < Roads.Count; i++)
            {
                int a = Roads[i].cityStart - 1;
                int b = Roads[i].cityFinish - 1;

                g.DrawLine(penRoad, Cities[a], Cities[b]);
            }

            Font font = new Font(Font.FontFamily, 10);

            //  А здесь точки на городах
            for (int i = 0; i < Cities.Count; i++)
            {
                g.FillEllipse(Brushes.Blue, Cities[i].X - 5, Cities[i].Y - 5, 10, 10);
                g.DrawString(CitiesName[i], font, Brushes.Black, Cities[i].X, Cities[i].Y-25);
            }

            

        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {

        }

        private void dataDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSmallRoad_Click(object sender, EventArgs e)
        {
            int a = dataDriver.NewRowIndex;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Road
    {
        public int cityStart;
        public int cityFinish;
        public Road(int a, int b)
        {
            cityStart = a;
            cityFinish = b;
        }
    }

}
