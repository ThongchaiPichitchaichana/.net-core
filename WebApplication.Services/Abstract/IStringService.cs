namespace WebApplication.Services.Abstract
{
    public interface IStringService
    {
        bool IsPalindrome(string value);
        string ReverseWords(string value);
    }
}