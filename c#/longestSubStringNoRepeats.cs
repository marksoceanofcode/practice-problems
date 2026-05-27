public class LengthOfLongestSubstring {
  public static int LengthOfLongestSubstringMain(string s) {
    //We want to find the length of the longest sub-string with no repeat characters.
    //will use IndexOf to check if out current string has the next character
    //Will index the string using [x]

    string answer = "";
    string tempAnswer = "";

    if(s.Length <= 1){
        answer = s;
    }
    else{
      answer = tempAnswer = s[0].ToString();

      for(int i = 1; i < s.Length; i++){
        if(tempAnswer.IndexOf(s[i]) == -1){ //If it does not exist in tempAnswer
            tempAnswer += s[i].ToString();

            if(tempAnswer.Length > answer.Length){ //Only update the answer if the new string becomes longer
              answer = tempAnswer;
            }
        }
        else{ //If the character already exists in the substring
          int startFrom = tempAnswer.IndexOf(s[i]) + 1; //Figure out when to start including characters from the tempAnswer

          tempAnswer += s[i].ToString(); //Start looking again for a longer substring but, include all previous characters that are not duplicates
          tempAnswer = tempAnswer.Substring(startFrom);
        }
      }
    }
    
    Console.WriteLine("Answer: " + answer);
    return answer.Length;
  }

  static void Main(string[] args) //string[] args enables accepting command line arguments
  {
    int subStringLen = LengthOfLongestSubstringMain("dvdf");
    Console.WriteLine(subStringLen);
  }
}