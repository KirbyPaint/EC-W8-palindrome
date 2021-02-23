using System;

namespace Palindrome
{
  public class Palindromes
  {

    public bool checkPalindrome(string word, string reversed)
    {
      if (word == reversed)
      {
        return true;
      } else return false;
    }
    public string ReverseWord(string userWord)
    {
      char[] palindromeArray = userWord.ToCharArray();
      Array.Reverse( palindromeArray );

      string reversedWord = "";

      foreach(char letter in palindromeArray)
      {
        reversedWord += letter;
      }
      return reversedWord;
    }

    public string SquishSentance(string userSentance)
    {
      char[] sentanceArray = userSentance.ToCharArray(); 
      string sentance = "";
      foreach(char element in sentanceArray)
      {
        Console.WriteLine(element);
        if(!char.IsPunctuation(element))
        {
          sentance += element;
        } 
      }
      sentance = sentance.Replace(" ","");
      sentance = sentance.ToLower();
      return sentance;
    }
    public static void Main()
    {
      Palindromes myReverse = new Palindromes();
      Console.WriteLine("Enter X if you'd like to check a word, Y for a number and Z for a sentance");
      string answer = Console.ReadLine();
      if(answer == "X" || answer == "x")
      {
        Console.WriteLine("Enter the word you would like to check!");
        string userWord = Console.ReadLine();
        string reverseWordOutput = myReverse.ReverseWord(userWord);
        Console.WriteLine(reverseWordOutput);
        Console.WriteLine(myReverse.checkPalindrome(userWord, reverseWordOutput));
      }
      else if (answer == "Y" || answer == "y")
      {
        Console.WriteLine("Enter the number you would like to check!");
        string userNumber = Console.ReadLine();
        string reverseNumberOutput = myReverse.ReverseWord(userNumber);
        Console.WriteLine(reverseNumberOutput);
        Console.WriteLine(myReverse.checkPalindrome(userNumber, reverseNumberOutput));
      } 
      else if (answer == "Z" || answer == "z")
      {
        Console.WriteLine("Enter the sentance you would like to check!");
        string userSentance = Console.ReadLine();
        string squishedSentance = myReverse.SquishSentance(userSentance);
        string sentanceOutput = myReverse.ReverseWord(squishedSentance);
        Console.WriteLine(sentanceOutput);
        Console.WriteLine(myReverse.checkPalindrome(squishedSentance, sentanceOutput));
      }
    }

    
  }
}