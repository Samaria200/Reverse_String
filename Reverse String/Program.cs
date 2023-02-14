string requiredStr, reversedString;
requiredStr = "SAMARIA";
reversedString = "";
Console.WriteLine("Value of given String is: {0}", requiredStr);
int a;
a = requiredStr.Length - 1;
while (a >= 0)
{
    reversedString = reversedString + requiredStr[a];
    a--;
}
Console.WriteLine("Reversed string is: {0}", reversedString);
Console.ReadLine();