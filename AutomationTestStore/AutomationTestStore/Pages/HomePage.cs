using AutomationTestStore.Driver;
using OpenQA.Selenium;

namespace AutomationTestStore.Pages
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement LoginButton => driver.FindElement(By.Id("customer_menu_top"));








        public void klikniNaDugme(string Text)
        {
            
        }
    }
}
