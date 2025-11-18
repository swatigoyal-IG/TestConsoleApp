// See https://aka.ms/new-console-template for more information
Console.WriteLine("********** - String Manipulation - *********");

// Initialize with a regular string literal.
string s1 = "This is a literal string.";
String s2 = "This is a literal string.";
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(s2)}: {s2}");
// Declare without initializing. (possible null exception)
string s3;
// Initialize to null. (possible null exception)
string? s4 = null;
// Initialize as an empty string.
string s5 = string.Empty; //""
string s6 = "";
// Verbatim string literal.
string oldPath = "C:\\Program Files\\Downloads";
string newPath = @"C:\Program Files\Downloads";
Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
Console.WriteLine($"{nameof(newPath)}: {newPath}");
// Use a const string to prevent modification to a string.
const string constString = "This string cannot be changed.";
Console.WriteLine($"{nameof(constString)}: {constString}");
//constString = "Trying to change"; // This will cause a compile-time error.
// Escape sequences and characters
//She said, "I have your phone".
string sentence = "She said, \"I have your phone\".\r\n This is the next line.";
// Raw string literals
string rawLiteral = """ She said, "I have your phone". """;
string rawLiteral1 = """ 
    This is a raw string literal.
    It can span multiple lines.
    It preserves whitespace and formatting.
    Path = "C:\\Program Files\\Downloads";
    """;
Console.WriteLine($"{nameof(sentence)}: {sentence}");
Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)}: {rawLiteral1}");

// Review concatenation and interpolation
//s1 = s1 + s2;
//s1 += s2;
string newString = $"{s1} {s2} Some random literal text ";
string newString1 = s1 + $"{s1} {s2} some random literal text ";
string newString2 = String.Format("Literal string {0} {1}", s1, s2);
Console.WriteLine($"{nameof(s1)}: {s1}");
Console.WriteLine($"{nameof(newString)}: {newString}");
Console.WriteLine($"{nameof(newString1)}: {newString1}");
Console.WriteLine($"{nameof(newString2)}: {newString2}");
/* String manipulation methods and Properties */

// Null or empty checks
// find the length of a string

if(!string.IsNullOrEmpty(s1))
    Console.WriteLine($"{nameof(s1)} has length: {s1.Length}");
if (!string.IsNullOrEmpty(s4))
    Console.WriteLine($"{nameof(s4)} has length: {s4.Length}");
if (!string.IsNullOrEmpty(s5))
    Console.WriteLine($"{nameof(s5)} has length: {s5.Length}");
if (!string.IsNullOrEmpty(s6))
    Console.WriteLine($"{nameof(s6)} has length: {s6.Length}");

// Substrings
string subString = s1.Substring(5);
string subString1 = s1.Substring(5, 5);
Console.WriteLine($"{nameof(subString)}: {subString}");
Console.WriteLine($"{nameof(subString1)}: {subString1}");

//Splitting strings
var splitStrings = s2.Split(' ');
for(int i=0; i< splitStrings.Length; i++)
{
    Console.WriteLine($"splitStrings[{i}]: {splitStrings[i]}");
}
//Replace
string replacedString = s1.Replace('s', 'V');
Console.WriteLine($"Original String {nameof(s1)}: {s1}");
Console.WriteLine($"After replacing s with V {nameof(replacedString)}: {replacedString}");
string replacedString1 = s1.Replace("string", "chicken");
Console.WriteLine($"After replacing string with chicken {nameof(replacedString1)}: {replacedString1}");
//Convert to string
string salary = 1000000.ToString();
int value = 12345;
string strValue = value.ToString();
bool isTrue = true;
string strBool = isTrue.ToString();
//Changing formatting
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(value) + ": " + value.ToString("C"));
//String comparison
