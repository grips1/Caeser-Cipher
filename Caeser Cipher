using System;

class Program
{
    public static void Main()
    {
        int Pindex, length, remaining, shift_value;
        string Message;
        char[] Alphabet_lowercase = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        Console.Write("Enter the message you wish to encrypt: ");
        Message = Console.ReadLine();
        Console.Write("Enter your desired shift value: ");
        shift_value = int.Parse(Console.ReadLine());
        Console.WriteLine("Using shift value of " + shift_value + "...");
        char[] MessageArray = Message.ToCharArray();
        length = MessageArray.Length;
        for(int i = 0; i < length; i++)
        {
            Pindex = Array.IndexOf(Alphabet_lowercase, MessageArray[i]);
            if(Pindex == 25)
            {
                Pindex = 0;
            }
            else if(Pindex + shift_value > 27)
            {
                remaining = 26 - Pindex; // remaining slots until it throws an error
                Pindex = -1; 
                
            }
            else if(Pindex + shift_value == 27)
            {
                Pindex = 0;
                shift_value = 0;
            }                     
            MessageArray[i] = Alphabet_lowercase[Pindex + shift_value];
        }    
        string EncryptedMessage = new string(MessageArray);
        Console.WriteLine(EncryptedMessage);
    }
}
