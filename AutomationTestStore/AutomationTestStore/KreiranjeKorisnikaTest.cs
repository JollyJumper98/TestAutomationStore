using AutomationTestStore.Driver;
using AutomationTestStore.Pages;

namespace AutomationTestStore
{
    public class Tests
    {
        HomePage homePage;
        KreiranjeNalogaPage kreiranjeNaloga;
        UnosInformacijaZaNalogPage unosInformacija;
        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            homePage = new HomePage();
            kreiranjeNaloga = new KreiranjeNalogaPage();
            unosInformacija = new UnosInformacijaZaNalogPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();
        }
        [Test]
        public void KreiranjeKorisnika()
        {
            homePage.LoginButton.Click();
            kreiranjeNaloga.klikniNaDugme("Continue");
            unosInformacija.posaljiPodatke("AccountFrm_firstname", "Dusan");
            unosInformacija.posaljiPodatke("AccountFrm_lastname", "Dobric");
            unosInformacija.posaljiPodatke("AccountFrm_email", "dusan@gmail.com");
            unosInformacija.posaljiPodatke("AccountFrm_telephone", "056432423");
            unosInformacija.posaljiPodatke("AccountFrm_fax", "@345");
            unosInformacija.posaljiPodatke("AccountFrm_company", "Comtrade");
            unosInformacija.posaljiPodatke("AccountFrm_address_1", "Dositeja Obradovica 33");
            unosInformacija.posaljiPodatke("AccountFrm_city", "Belgrade");
            unosInformacija.izaberiRegiju("3517");
            unosInformacija.posaljiPodatke("AccountFrm_postcode", "22304");
            unosInformacija.izaberiDrzavu("222");
            unosInformacija.posaljiPodatke("AccountFrm_loginname", "Dusan");
            unosInformacija.posaljiPodatke("AccountFrm_password", "carinho");
            unosInformacija.posaljiPodatke("AccountFrm_confirm", "carinho");
            unosInformacija.klikniNaDugme("AccountFrm_newsletter0");
            unosInformacija.klikniNaDugme("AccountFrm_agree");

            Assert.That(unosInformacija.Poruka.Text, Is.EqualTo(" Your Account Has Been Created!"));
        }
    }
}