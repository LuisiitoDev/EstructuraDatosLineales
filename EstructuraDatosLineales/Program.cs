// See https://aka.ms/new-console-template for more information
using EstructuraDatosLineales.Palindrome;

var head = new PalindromeNode
{
    Value = 1,
    Next = new()
    {
        Value = 9,
        Next = new()
        {
            Value = 7,
            Next = new()
            {
                Value = 2,
                Next = new()
                {
                    Value = 1
                }
            }
        }
    }
};

var head2 = new PalindromeNode
{
    Value = 1,
    Next = new()
    {
        Value = 9,
        Next = new()
        {
            Value = 9,
            Next = new()
            {
                Value = 1
            }
        }
    }
};


Console.WriteLine("Is Palindrome: " + PalindromeListCycle.isPalindrome(head));
Console.WriteLine("Is Palindrome: " + PalindromeListCycle.isPalindrome(head2));
Console.ReadLine();
