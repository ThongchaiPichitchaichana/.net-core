using System;
using WebApplication.Services.Abstract;

namespace WebApplication.Services.Concrete
{
    public class StringService: IStringService
    {
        public bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }

        public string ReverseWords(string value)
        {
            string[] words = value.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
