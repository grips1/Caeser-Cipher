using System;
namespace suckmynuts
{
    class Caeser_Cipher
    {
        public static void Main()
        {
            int Pindex, length, shift_value;
            int remaining = 0;
            string Message;
            char[] Alphabet_lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); // Creats an array of the alphabet (26 chars, 25 spots)

            Console.Write("Enter the message you wish to encrypt: ");
            Message = Console.ReadLine(); // Input message

            Console.Write("Enter your desired shift value: ");
            shift_value = int.Parse(Console.ReadLine()); //Input shift value

            Console.WriteLine("Using shift value of " + shift_value + "...");
            char[] MessageArray = Message.ToCharArray(); // Converts message to an array of letters

            length = MessageArray.Length; 

            for(int i = 0; i < length; i++)
            {
                Pindex = Array.IndexOf(Alphabet_lowercase, MessageArray[i]);
                
                if (Pindex + shift_value > 25)
                {
                    remaining = 26 - (Pindex + shift_value); // can give a negative num 
                    Pindex = -2; 
                }
                if(MessageArray[i] == ' ')
                    continue;
                MessageArray[i] = Alphabet_lowercase[Pindex + shift_value - remaining];    
            }
            string EncryptedMessage = new string(MessageArray);
            Console.WriteLine(EncryptedMessage);

        }
    }
}