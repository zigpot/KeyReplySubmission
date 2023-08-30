class Palindrome{
  public static string longestPalindrome(string s){
    for (int window = s.Length; window > 1; window--){
      for(int offset = 0; offset <= s.Length - window; offset++){
        if(isPalindrome(s.Substring(offset, window))){
          return s.Substring(offset, window);
        }
      }
    }
    return s.Substring(0,1);
  }
  public static bool isPalindrome(string s){
    if(s.Length <= 1) {return true;}
        int a = 0;
        int b = s.Length - 1 ;
        while (a < b){
            if (s[a] != s[b]) return false;
            a = a + 1;
            b = b - 1;
        }
        return true;
  }
}
