using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
	class TestSuitForLoginPage
	{
		LogInPageObject page;


		[SetUp]
		public void Initialization()
		{
			BrowserProperies.driver = new ChromeDriver();
			BrowserProperies.driver.Manage().Window.Maximize();
			BrowserProperies.driver.FindElement(By.LinkText("Вход в личный кабинет")).Click();
			page = new LogInPageObject();
		}

		[Test]
		public void InvalidData()
		{
			page.FillLoginForm("123", "123123");
		}
	}
}
