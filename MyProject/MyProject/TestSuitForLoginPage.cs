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
	class TestSuitForLoginPage
	{
		LogInPageObject page;


		[SetUp]
		public void Initialization()
		{
			BrowserProperies.OpenLoginWindow();
			
			Thread.Sleep(3000);
		}

		[Test]
		public void IncorrectEmail()
		{
			LogInPageObject page = new LogInPageObject();

			ExcelUtil.PopulateInCollection(@"D:\u1.xlsx");
			string UserName = ExcelUtil.ReadData(0, "UserName");
			string Password = ExcelUtil.ReadData(0, "Password");
			page.FillLoginForm(UserName, Password);
			page.ClickLoginButton();

			Thread.Sleep(2000);

			StringAssert.Contains("Неправильный email или пароль", page.Error.Text);
		}

		[Test]
		public void EmptyLogin()
		{
			LogInPageObject page = new LogInPageObject();
			
			page.ClickLoginButton();
			
			Thread.Sleep(2000);
			StringAssert.Contains("Логин обязателен", page.Error.Text);
		}

		[TearDown]
		public void Close()
		{
			BrowserProperies.driver.Quit();
		}
	}
}
