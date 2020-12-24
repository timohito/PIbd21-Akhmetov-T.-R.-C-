using System.Drawing;

namespace Dozer
{
	public class Car : Vehicle
	{
		protected readonly int carWidth = 90;

		protected readonly int carHeight = 50;

		public Car(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		
		protected Car(int maxSpeed, float weight, Color mainColor, int carWidth, int carHeight)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			this.carWidth = carWidth;
			this.carHeight = carHeight;
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - carWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - carHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black);
			Brush osn = new SolidBrush(MainColor);
			Brush kus = new SolidBrush(Color.Black);

			g.DrawRectangle(pen, _startPosX, _startPosY, 100, 45);
			g.DrawRectangle(pen, _startPosX + 20, _startPosY - 30, 30, 30);
			g.FillRectangle(kus, _startPosX + 20, _startPosY - 30, 30, 30);
			g.FillRectangle(osn, _startPosX, _startPosY, 100, 25);
			g.DrawEllipse(pen, _startPosX, _startPosY + 25, 100, 20);
			g.DrawEllipse(pen, _startPosX, _startPosY + 25, 20, 20);
			g.DrawEllipse(pen, _startPosX + 20, _startPosY + 25, 20, 20);
			g.DrawEllipse(pen, _startPosX + 40, _startPosY + 25, 20, 20);
			g.DrawEllipse(pen, _startPosX + 60, _startPosY + 25, 20, 20);
			g.DrawEllipse(pen, _startPosX + 80, _startPosY + 25, 20, 20);
		}
	}
}

