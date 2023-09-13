namespace Example;
public static class StringExtensions {
    public static Dictionary<string, int> GetStatistics(this string s) {

        Dictionary<string, int> stat = new Dictionary<string, int>();

        var chars = s.ToCharArray();
        stat["upper"] = 0;
        stat["lower"] = 0;
        stat["digit"] = 0;
        stat["special"] = 0;

        for(int i = 0; i < chars.Length; i++)
        {
           if(char.IsDigit(chars[i]))
           {
                stat["digit"]++;
           }
           else if (char.IsUpper(chars[i]))
           {
               stat["upper"]++;
            }
            else if (char.IsLower(chars[i]))
            {
               stat["lower"]++;
            }
            else
            {
                stat["special"]++;
            }
        }
        return stat;
    }
}