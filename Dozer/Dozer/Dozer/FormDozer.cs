using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dozer
{
    public partial class FormDozer : Form
	{
		private Dozer dozer;

		public FormDozer()
		{
			InitializeComponent();
		}

		private void Draw()	
		{
			Bitmap bmp = new Bitmap(pictureBoxCars.Width, pictureBoxCars.Height);
			Graphics gr = Graphics.FromImage(bmp);
			dozer.DrawTransport(gr);
			pictureBoxCars.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			dozer = new Dozer(100, 1000, Color.Yellow, Color.Black, true, true);
			dozer.SetPosition(rnd.Next(10, 60), rnd.Next(100, 400), pictureBoxCars.Width, pictureBoxCars.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					dozer.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					dozer.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					dozer.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					dozer.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}
