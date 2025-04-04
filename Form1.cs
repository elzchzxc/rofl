using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rofl
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ты проиграл";
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ClientSize = new Size(200, 200);

            var pic = new PictureBox();
            pic.Image = Properties.Resources.meme; // meme — имя ресурса
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = DockStyle.Fill;

            this.Controls.Add(pic);

           // Обработчик для клика по картинке, чтобы закрыть приложение
            pic.Click += (object picSender, EventArgs picArgs) => Application.Exit();

            // Обработчик для наведения мыши на картинку
            pic.MouseEnter += (object picSender, EventArgs picArgs) => MoveForm();
        }

        // Метод для случайного перемещения формы
        private void MoveForm()
        {
            // Генерация случайной позиции для всей формы в пределах экрана
            int maxX = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int maxY = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

            int randomX = _random.Next(0, maxX);
            int randomY = _random.Next(0, maxY);

            // Перемещение формы на случайную позицию
            this.Location = new Point(randomX, randomY);
        }
    }
}
