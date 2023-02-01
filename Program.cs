using System;

namespace RSVPReader;
class Program
{
    static void Main(string[] args)
    {
		double wpm = Convert.ToDouble(args[0]);
		string text = args[1];
        RSVPReader.Rsvp.Read(wpm, text);
    }
}
