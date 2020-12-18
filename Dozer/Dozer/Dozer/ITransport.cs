using System.Drawing;

namespace Dozer
{
	public interface ITransport
	{
		void SetPosition(int x, int y, int width, int height);
		
		void MoveTransport(Direction direction);
		
		void DrawTransport(Graphics g);
	}
}

