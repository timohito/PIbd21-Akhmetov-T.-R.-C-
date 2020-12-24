using System.Drawing;

namespace Dozer
{
	class Dozer : Car 
	{
		public Color DopColor { private set; get; }

		public bool Kovsh { private set; get; }

		public bool Truba { private set; get; }

		public Dozer(int maxSpeed, float weight, Color mainColor, Color dopColor, bool kovsh, bool truba) : 
			base(maxSpeed, weight, mainColor, 100, 60)
		{
			DopColor = dopColor;
			Kovsh = kovsh;
			Truba = truba;
		}
		
		public override void DrawTransport(Graphics g)
		{
			if (Kovsh)
			{
				Pen pen = new Pen(DopColor);
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

			base.DrawTransport(g);
		}

		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
	}
}

