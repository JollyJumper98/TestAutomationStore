using AutomationTestStore.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestStore.Pages
{
    public class UnosInformacijaZaNalogPage
    {
        private IWebDriver? driver = WebDrivers.Instance;
        public IWebElement Regija => driver.FindElement(By.Id("AccountFrm_zone_id"));
        public IWebElement Drzava => driver.FindElement(By.Id("AccountFrm_country_id"));
        public IWebElement Poruka => driver.FindElement(By.XPath("//span[@class='maintext']"));

        






        public void posaljiPodatke(string Id, string podatak)
        {
            string fieldLocator = Id;
            By locator = By.Id(fieldLocator);
            driver.FindElement(locator).SendKeys(podatak);
        }
        public void izaberiDrzavu(string text)
        {
            SelectElement element1 = new SelectElement(Drzava);
            element1.SelectByValue(text);
        }
        public void klikniNaDugme(string Id)
        {
            string pretplataLocator = Id;
            By locator = By.Id(pretplataLocator);
            driver.FindElement(locator).Click();
        }
        public void izaberiRegiju(string text)
        {
            SelectElement element = new SelectElement(Regija);
            element.SelectByValue(text);
        }
        public void asertacijaPoruke(string text)
        {
            SelectElement poruka = new SelectElement(Poruka);
            poruka.SelectByText(text);
        }
    }
}
