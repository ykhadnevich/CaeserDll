

using Class;
var a = new Class1();

Console.WriteLine("Enter value (1) or (2)");
int val = Convert.ToInt32(Console.ReadLine());
switch (val)
{
    case 1:
        Console.WriteLine("Please enter message to encrypt: ");
        string myString = Console.ReadLine();
        myString = myString.ToLower();
        char[] message = myString.ToCharArray();
        Console.WriteLine("Please enter int: ");
        int key = Convert.ToInt32(Console.ReadLine());
        string secret = a.Encrypt(message, key);
        Console.WriteLine($"Secrete-code:{secret}");
        break;
    case 2 :
        Console.WriteLine("Please enter message to decrypt: "); 
        string msgString = Console.ReadLine();
        msgString = msgString.ToLower();
        char[] messages = msgString.ToCharArray();
        Console.WriteLine("Please enter int: ");
        int keys = Convert.ToInt32(Console.ReadLine());
        string secrets = a.Decrypt(messages, keys);
        Console.WriteLine($"Secrete-code:{secrets}");
        break;
}