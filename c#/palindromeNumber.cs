/*
What is a palindrome? A palindrome is a number that reads the same when reveresed. Example, 10 is not a palindrom because 10 != 01. 121 is but, -121 is not because
the reverse is 121-

*/

class PalindromeNumberChecker
{
  //"static" is used because we need to call the method even though no instances of the object have been created
  //C# requires this entry point

  static public bool CheckNumber(int x)
  {
    //Check if the number is negative, we can automatically return false is so because -121 != 121-
    if (int.IsNegative(x))
    {
      return false;
    }

    string tempConversion = x.ToString();
    string reversedNumber = "";

    for (int i = tempConversion.Length - 1; i >= 0; i--)
    {
      reversedNumber += tempConversion[i].ToString();
    }

    if(reversedNumber[reversedNumber.Length-1].ToString() == "-"){
      return false;
    }

    int answer = int.Parse(reversedNumber);
    return answer == x;
  }

  static void Main(string[] args)
  {
    bool isPalindrome = CheckNumber(-121);
    Console.WriteLine("The number is a palindrome, true or false?");
    Console.WriteLine(isPalindrome);
  }
}