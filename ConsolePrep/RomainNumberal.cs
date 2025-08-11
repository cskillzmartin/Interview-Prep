
namespace ConsolePrep
{
    public class RomanNumeral
    {
        public int RomanToInt(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }

            int output = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (i != 0 && nums[s[i - 1]] < nums[s[i]])
                {
                    output += nums[s[i]] - nums[s[i - 1]];
                    i = i - 2;
                }

                if (i != 0 && s[i] == 'I')
                {
                    int scan = 4;
                    var iCount = 1;
                    for (int j = i - 1; j >= 0 && scan >= 0; j--)
                    {
                        if (s[j] == 'I')
                        {
                            iCount += 1;
                        }
                        else
                        {
                            output += nums[s[j]] + iCount;
                        }
                        scan -= 1;
                    }
                }
            }




            return output;
        }

        public static readonly Dictionary<char, int> nums = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    }
}