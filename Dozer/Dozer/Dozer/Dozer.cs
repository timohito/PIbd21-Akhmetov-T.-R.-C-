using System.Drawing;

namespace Dozer
{
    class Dozer
	{
		private float _startPosX;

		private float _startPosY;

		private int _pictureWidth;

		private int _pictureHeight;

		private readonly int carWidth = 100;

		private readonly int carHeight = 60;

		public int MaxSpeed { private set; get; }

		public float Weight { private set; get; }

		public Color MainColor { private set; get; }

		public Color DopColor { private set; get; }
	
		public bool Kovsh { private set; get; }

		public bool Truba { private set; get; }
	
		public Dozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool kovsh, bool truba)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Kovsh = kovsh;
			Truba = truba;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}

		public void MoveTransport(Direction direction)
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

		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(DopColor);
			Brush osn = new SolidBrush(MainColor);
			Brush dop = new SolidBrush(DopColor);

            g.DrawRectangle(pen, _startPosX, _startPosY, 100, 45);
            g.DrawRectangle(pen, _startPosX + 20, _startPosY - 30, 30, 30);
            g.FillRectangle(dop, _startPosX + 20, _startPosY - 30, 30, 30);
            g.FillRectangle(osn, _startPosX, _startPosY, 100, 25);
            g.DrawEllipse(pen, _startPosX, _startPosY + 25, 100, 20);
            g.DrawEllipse(pen, _startPosX, _startPosY + 25, 20, 20);
            g.DrawEllipse(pen, _startPosX + 20, _startPosY + 25, 20, 20);
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 25, 20, 20);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY + 25, 20, 20);
            g.DrawEllipse(pen, _startPosX + 80, _startPosY + 25, 20, 20);

            if (Kovsh)
			{
				g.DrawLine(pen, _startPosX + 100, _startPosY + 10, _startPosX + 120, _startPosY + 25);
				g.DrawLine(pen, _startPosX + 120, _startPosY + 25, _startPosX + 120, _startPosY + 45);
				g.DrawLine(pen, _startPosX + 120, _startPosY + 45, _startPosX + 150, _startPosY + 45);
				g.DrawLine(pen, _startPosX + 150, _startPosY + 45, _startPosX + 120, _startPosY + 25);
			}

			if (Truba)
			{
				Brush truba = new SolidBrush(DopColor);
				g.FillRectangle(truba, _startPosX + 80, _startPosY - 15, 5, 15);
			}
		}
	}
}

