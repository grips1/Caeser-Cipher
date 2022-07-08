using System;
using System.Linq;

namespace Caeser_Cipher
{
	public class NewBaseType
	{
		public static void Main(string[] args)
		{
			int Pindex, length, shift_value;
			int remaining = 0;
			string Message = args[0];
			shift_value = int.Parse(args[1]);
			char[] Alphabet_uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			char[] Alphabet_lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); // Creats an array of the alphabet
			Console.WriteLine("Using shift value of " + shift_value + "...");
			char[] MessageArray = Message.ToCharArray(); // Converts message to an array of letters
			length = MessageArray.Length;
			for (int i = 0; i < length; i++)
			{
				if (MessageArray[i] == ' ') continue;	
				if (Alphabet_lowercase.Contains(MessageArray[i])) // Subroutine for lowercase letters
				{
					Pindex = Array.IndexOf(Alphabet_lowercase, MessageArray[i]);
					if (Pindex + shift_value > 25)
					{
						remaining = 26 - (Pindex + shift_value);
						Pindex = -2;
					}

					MessageArray[i] = Alphabet_lowercase[Pindex + shift_value - remaining];
				}
				else if ((Alphabet_uppercase.Contains(MessageArray[i]))) // Subroutine for uppercase letters
				{
					Pindex = Array.IndexOf(Alphabet_uppercase, MessageArray[i]);
					if (Pindex + shift_value > 25)
					{
						remaining = 26 - (Pindex + shift_value);
						Pindex = -2;
					}

					MessageArray[i] = Alphabet_uppercase[Pindex + shift_value - remaining];
				}
			}

			string EncryptedMessage = new string (MessageArray);
			Console.WriteLine(EncryptedMessage);
		}
	}
}
