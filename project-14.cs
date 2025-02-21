This code reverse a string 
and count the number of times a particular character appears
* /

string message = "The quick brown fox jumps over the lazy dog.";

char[] reversedMessage = message.ToCharArray();
Array.Reverse(reversedMessage);

int letter_O = 0;

foreach (char letter in reversedMessage)
{
    if (letter == 'o')
    {
        letter_O++;
    }
}

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letter_O} times.");
