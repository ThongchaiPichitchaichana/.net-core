using NUnit.Framework;
using WebApplication.Services.Abstract;

namespace WebApplication.Services.Tests
{
    public class StringServiceTests
    {
        private IStringService _stringService;
        [SetUp]
        public void Setup()
        {
        }

        //todo: fix test
        [TestCase("madam",true)]
        [TestCase("step on no pets",true)]
        [TestCase("book",false)]
        public void CanIdentifyPalindromes(string value, bool expected)
        {
            var isPalindrome = _stringService.IsPalindrome(value);
            Assert.AreEqual(isPalindrome,expected);
        }

        //todo: fix test
        [TestCase("welcome to control expert", "expert control to welcome")]
        public void ReverseWordsInSentence(string value, string expected)
        {
            var isPalindrome = _stringService.ReverseWords(value);
            Assert.AreEqual(isPalindrome,expected);
        }
    }
}