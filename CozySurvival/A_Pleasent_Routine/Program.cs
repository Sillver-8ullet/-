using System;
using A_Pleasant_Routine;

namespace A_Pleasant_Routine
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			using (var game = new RayScan())
				game.Run();
		}
	}
}