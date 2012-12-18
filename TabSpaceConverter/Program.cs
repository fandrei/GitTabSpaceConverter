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
					line = ReplaceBeginning(line, "\t", "    ");

				if (action == Action.MakeTabs)
					line = ReplaceBeginning(line, "    ", "\t");

				Console.WriteLine(line);
			}
		}

		static string ReplaceBeginning(string text, string match, string newVal)
		{
			var res = new StringBuilder();

			for (int i = 0; i < text.Length; )
			{
				if (Contains(text, match, i))
				{
					res.Append(newVal);
					i += match.Length;
				}
				else
				{
					res.Append(text, i, text.Length - i);
					break;
				}
			}

			return res.ToString();
		}

		static bool Contains(string text, string match, int pos)
		{
			for (int i = pos; ; i++)
			{
				if (i - pos >= match.Length)
					return true;
				if (i >= text.Length)
					break;
				if (text[i] != match[i - pos])
					return false;
			}
			return false;
		}
	}
}
