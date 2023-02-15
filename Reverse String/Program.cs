//code to reverse string
string requiredStr, reversedString;
requiredStr = "SAMARIA";
reversedString = "";
Console.WriteLine("Value of given String is: {0}", requiredStr);
int aValue;
 aValue= requiredStr.Length - 1;
while (aValue >= 0)
{
    reversedString = reversedString + requiredStr[aValue];
    aValue--;
}
Console.WriteLine("Reversed string is: {0}", reversedString);
Console.ReadLine();
