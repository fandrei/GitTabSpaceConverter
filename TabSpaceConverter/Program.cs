using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace TabSpaceConverter
{
	enum Action { None, MakeTabs, MakeSpaces }

	class Program
	{
		static void Main(string[] args)
		{
			var action = Action.None;
			if (args.Length > 0)
			{
				action = (Action)Enum.Parse(typeof(Action), args[0]);
			}

			while (true)
			{
				var line = Console.ReadLine();
				if (line == null)
					break;

				if (action == Action.MakeSpaces)
					line = line.Replace("\t", "    ");

				if (action == Action.MakeTabs)
					line = line.Replace("    ", "\t");

				Console.WriteLine(line);
			}
		}
	}
}
