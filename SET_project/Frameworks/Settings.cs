using System;
using NUnit.Framework;

namespace SET_project.Frameworks
{
    public static class Settings
    {
        public const string Url = "http://52.177.12.77:8080/";
        public static readonly Drivers Driver = (Drivers) Enum.Parse(typeof(Drivers),TestContext.Parameters["Driver"] ?? "Chrome");

        public static readonly TimeSpan ImplicitWait = TimeSpan
            .FromMilliseconds(Convert.ToInt32(TestContext.Parameters["WaitTime"]??"5000"));

    }
}