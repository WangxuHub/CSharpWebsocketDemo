using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClientSocket
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex reg = new Regex (@"{<(.*?)>}");
			string name = "{<Byron>}";
			Match m = reg.Match (name);
			if (m.Groups.Count != 0) {
				name = Regex.Replace (m.Value, @"{<(.*?)>}", "$1");
			}
			Console.WriteLine (name);
		}
	}
}
