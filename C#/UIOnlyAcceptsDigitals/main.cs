/*User interface contains two types of user input controls: TextInput, which accepts all characters and NumericInput, which accepts only digits.

Implement the class TextInput that contains:

Public method void Add(char c) - adds the given character to the current value
Public method string GetValue() - returns the current value
Implement the class NumericInput that:

Inherits TextInput
Overrides the Add method so that each non-numeric character is ignored
For example, the following code should output "10":

TextInput input = new NumericInput();
input.Add('1');
input.Add('a');
input.Add('0');
Console.WriteLine(input.GetValue());
*/

using System;
using System.Collections.Generic; //needed for List

public class TextInput 
{
    public static IList<char> added  = new List<char>(); //dynamic array!! (vector) 
    
    public virtual void Add(char c) //adding the values to List added!
    {
        added.Add(c);
    }
    public string GetValue()    //returns the values in added List!
    {
        string C = "";
        foreach (char i in added)
        {
            C = C + i;
        }
        return C;
    }
}

public class NumericInput : TextInput   // NumericInput, Inherits TextInput
{

    public override void Add(char c) // Overrides the Add method so that each non-numeric character is ignored
    {
        if (c < '0' || c > '9')
        {
        
        }
        else 
        {
            added.Add(c);
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}