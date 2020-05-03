using System;
using NUnit.Framework;
using SET_project.PageObject;

namespace SET_project.Tests
{
    [TestFixture]
    public class ChangeLanguage : BaseTest
    {
        private Lang _header;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _header = new Lang(Driver);

        }

        [TestCase(true, true)]
        [TestCase(true, false)]
        
        public void ChangeLang(bool isCorrect, bool isEngSelected)
        {
            bool isLangCorrect = _header.LangButtonClick(isEngSelected).IsLangChange(isEngSelected);
            Assert.That(isLangCorrect, Is.EqualTo(isCorrect),
                $"Language changed on {(isEngSelected ? "En" : "Uk")}"+$", but we expected opposite");
                

        }

    }
}