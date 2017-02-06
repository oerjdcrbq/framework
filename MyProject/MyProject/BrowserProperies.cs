using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
	class BrowserProperies
	{
		public static IWebDriver driver { get; set; }
		public static void OpenLoginWindow()
		{
			BrowserProperies.driver = new ChromeDriver();
			BrowserProperies.driver.Navigate().GoToUrl("http://www.keramis.com.ua/");
			BrowserProperies.driver.FindElement(By.LinkText("Вход в личный кабинет")).Click();
			BrowserProperies.driver.SwitchTo().Window(BrowserProperies.driver.WindowHandles.Last());
		}
	}
}
