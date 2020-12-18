using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dozer
{
	public partial class FormDozer : Form
	{
		private ITransport car;

		public FormDozer()
		{
			InitializeComponent();
		}

		private void Draw()	
		{
			Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
			Graphics gr = Graphics.FromImage(bmp);
			car.DrawTransport(gr);
			pictureBoxCars.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			car = new Car(100, 1000, Color.Yellow);
			car.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxCars.Width, pictureBoxCars.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					car.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					car.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					car.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					car.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

        private void buttonCreateDozer_Click(object sender, EventArgs e)
        {
			Random rnd = new Random();
			car = new Dozer(100, 1000, Color.Yellow, Color.Black, true, true);
			car.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxCars.Width, pictureBoxCars.Height);
			Draw();
		}
    }
}
