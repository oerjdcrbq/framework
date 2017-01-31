using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		[SetUp]
		public void init()
		{
			BrowserProperies.driver = new ChromeDriver();
			BrowserProperies.driver.Navigate().GoToUrl("http://www.keramis.com.ua/");
		}

		[Test]
		public void Type()
		{
			BrowserProperies.driver.FindElement(By.LinkText("Вход в личный кабинет")).Click();
			BrowserProperies.driver.SwitchTo().Window(BrowserProperies.driver.WindowHandles.Last());
			Thread.Sleep(3000);
			LogInPageObject page = new LogInPageObject();
			page.LoginField.SendKeys("Misha");
			page.PasswordField.SendKeys("123123");
			Thread.Sleep(2000);
			page.CloseButton.Click();
			
		}
	}
}
