using System;
using System.IO;
using System.Threading;


namespace RSVPReader
{
	class Rsvp
	{
		public static void Read(double wordsPerMinute, string text)
		{
			Console.CursorVisible = false;
			double sec = (1.0 / (wordsPerMinute / 60.0));
			long wpm = ((long)(sec * 1000));
			foreach (string word in text.Split(' '))
			{
				Console.Clear();
				Console.WriteLine($"{word}");
				Thread.Sleep((int)wpm);
			}
			Console.CursorVisible = true;
		}
	}
}