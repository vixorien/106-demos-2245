// Chris Cascioli
// 1/27/25
// Demo of structs and their usage vs. classes

namespace StructDemo
{
	struct Point
	{
		// Making these public for a quick demo!
		public int X;
		public int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			// Test out some points
			Point p0 = new Point();
			p0.X = 10;
			p0.Y = 20;

			Point p1 = p0;
			p1.X = 99;
			p1.Y = 200;

			// Attempt to change p0 before printing
			ChangePoint(p0);
            Console.WriteLine(p0.X + ", " + p0.Y);

			// Compare structs in arrays and lists
			Point[] pointArray = new Point[5];
			pointArray[0] = new Point(2, 2);

			List<Point> pointList = new List<Point>();
			pointList.Add(new Point(9, 9));

			// Change both!
			pointArray[0].X *= 2;

			// This is INVALID code
			// pointList[0].X *= 2;

			// Must perform a copy/alter/replace
			Point temp = pointList[0];
			temp.X *= 2;
			pointList[0] = temp;

            // Print both!
            Console.WriteLine("Point array: " + pointArray[0].X);
			Console.WriteLine("List array: " + pointList[0].X);
		}

		static void ChangePoint(Point p)
		{
			p.X *= 2;
			p.Y *= 2;
		}
	}
}
