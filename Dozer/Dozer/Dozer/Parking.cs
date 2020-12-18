using System.Drawing;

namespace Dozer
{
    public class Parking<T> where T : class, ITransport
    {
        private readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 210;

        private readonly int _placeSizeHeight = 80;

        private readonly int rows;

        public Parking(int picWidth, int picHeight)
        {
            int columns = picWidth / _placeSizeWidth;
            rows = picHeight / _placeSizeHeight;
            _places = new T[columns * rows];
            pictureWidth = picWidth;
            pictureHeight = picHeight; ;
        }

        public static bool operator +(Parking<T> p, T car)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    car.SetPosition(i / p.rows * p._placeSizeWidth + 15, (i - i / p.rows * p.rows) * p._placeSizeHeight + 33, p.pictureWidth, p.pictureHeight);
                    p._places[i] = car;
                    return true;
                };
            }
            return false;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index < 0 || index > p._places.Length - 1)
            {
                return null;
            }
            T doz = p._places[index];
            p._places[index] = null;
            return doz;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}


