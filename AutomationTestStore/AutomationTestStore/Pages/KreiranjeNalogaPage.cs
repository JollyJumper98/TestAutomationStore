using AutomationTestStore.Driver;
using OpenQA.Selenium;

namespace AutomationTestStore.Pages
{
    public class KreiranjeNalogaPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        //NewCustomer
        public IWebElement ContinueButton => driver.FindElement(By.XPath("//button[@title='{Continue}']"));

        //ReturningCustomer
        public IWebElement LoginName => driver.FindElement(By.Id("loginFrm_loginname"));
        public IWebElement Password => driver.FindElement(By.Id("loginFrm_password"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[@title='{Login}']"));
        




        public void klikniNaDugme (string title)
        {
            string titlelocator = $"//button[@title='{title}']";
            By locator = By.XPath(titlelocator);
            driver.FindElement(locator).Submit();
        }
    }
}
