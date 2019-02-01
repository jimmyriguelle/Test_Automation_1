using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomation1
{
    [TestClass]
    public class Inputs
    {
        [TestMethod]
        public void textBoxes()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://formy-project.herokuapp.com/form");

            IWebElement text = driver.FindElement(By.Id("first-name"));

            IWebElement radioButton = driver.FindElement(By.Id("radio-button-1"));
            radioButton.Click();

            text.Clear();
            text.SendKeys("sending text");
            System.Threading.Thread.Sleep(3000);
        }

        //
        [TestMethod]
        public void radioButton()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://formy-project.herokuapp.com/form");

            IWebElement radioButton = driver.FindElement(By.Id("radio-button-1"));
            radioButton.Click();
        }
        //
        [TestMethod]
        public void checkbox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://formy-project.herokuapp.com/form");

            IWebElement checkBox = driver.FindElement(By.Id("checkbox-1"));
            int nbrOfTimesClick = new Random().Next(3) + 3;
            for (int i = 0; i < nbrOfTimesClick; i++)
            {
                checkBox.Click();
                System.Threading.Thread.Sleep(1300);
            }
            System.Threading.Thread.Sleep(3000);

            if (!checkBox.Selected)
            {
                checkBox.Click();
            }
        }

    }
}
