using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
	class LogInPageObject
	{
		public LogInPageObject()
		{
			PageFactory.InitElements(BrowserProperies.driver, this);
		}

		[FindsBy(How = How.Name, Using = "login")]
		public IWebElement LoginField { get; set; }

		[FindsBy(How = How.Name, Using = "password")]
		public IWebElement PasswordField { get; set; }

		[FindsBy(How = How.CssSelector, Using = "html.color_scheme_blue.csstransforms.csstransforms3d.csstransitions body div.dialog.new div.dialog-window.open div.cart.authentification div.wa-form form div.wa-field div.wa-value.wa-submit input.btn.btn-success")]
		public IWebElement SubmitButton { get; set; }

		[FindsBy(How = How.LinkText, Using = "Забыли пароль?")]
		public IWebElement ForgetPassword { get; set; }

		[FindsBy(How = How.LinkText, Using = "Зарегистрироваться")]
		public IWebElement RegistrationLink { get; set; }

		[FindsBy(How = How.CssSelector, Using = "html.color_scheme_blue.csstransforms.csstransforms3d.csstransitions body div.dialog.new div.dialog-window.open div.title a.dialog-close i.icon-remove")]
		public IWebElement CloseButton { get; set; }

		[FindsBy(How = How.CssSelector,Using = ".wa-error-msg")]
		public IWebElement Error { get; set; }


		public void FillLoginForm(string login, string password)
		{
			LoginField.SendKeys(login);
			PasswordField.SendKeys(password);
			bool a = SubmitButton.Enabled;
		}

		public void ClickLoginButton()
		{
			SubmitButton.Click();
		}
	}
}
