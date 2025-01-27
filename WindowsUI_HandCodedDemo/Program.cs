// Chris Cascioli
// 1/27/25
// Demo of starting with a console app
// and converting to a Windows Forms app
// (which is NOT how we usually do it)

namespace WindowsUI_HandCodedDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.Run(new MyFirstWindow());
		}
	}
}
