using System;


namespace RSVPReader.Arguments
{
	class Arguments
	{
		public static void Handle(string[] args)
		{
			double wpm;
			string text;
			switch(args.Length)
			{
				case 0:
					Console.WriteLine("No arguments supplied..");
					break;
				case 1:
					Console.WriteLine("Insufficient arguments..");
					break;
				case 2:
					wpm = Convert.ToDouble(args[0]);
					text = args[1];
					if (text == "-f")
					{
						Console.WriteLine("No file name was provided..");
					} else 
					{
						Rsvp.Read(wpm, text);
					}
					break;
				case 3:
					wpm = Convert.ToDouble(args[0]);
					text = args[2];
					if (args[1] == "-f")
					{
						Rsvp.ReadFromFile(wpm, text);
					} else 
					{
						Console.WriteLine($"Argument {args[1]} is invalid..");
					}
					break;
			}
		}
	}
}