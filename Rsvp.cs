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
			Console.WriteLine("Press Enter to start reading.");
			Console.ReadLine();
			Console.Clear();			
			foreach (string word in text.Split(' '))
			{
				Console.Write($"\r{ new string(' ', Console.WindowWidth - 1)} \r");
				Console.Write($"{new string(' ', Console.WindowWidth / 2)}{word}");
				Thread.Sleep((int)wpm);
			}
			Console.Clear();
			Console.CursorVisible = true;
		}

		public static void ReadFromFile(double wordsPerMinute, string filePath)
		{
			string text = File.ReadAllText(filePath);
			Read(wordsPerMinute, text);
		}

	}
}