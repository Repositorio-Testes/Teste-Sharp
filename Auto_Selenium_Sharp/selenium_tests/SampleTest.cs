using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.Profiler;
using OpenQA.Selenium.Support.UI;

namespace selenium_tests;

public class SampleTest
{
    [Test]
    [Category("Selenium")]
    public void NavigationTest()
    {
        ChromeDriver driver = new ChromeDriver();
        

        PageVehicleInsuranceApp vi = new PageVehicleInsuranceApp(driver);
        PageVehicleData vd = new PageVehicleData(driver);
        PageInsuranceData icd = new PageInsuranceData(driver);

        //Abrir Browser     
        vi.AbrirPagina("http://sampleapp.tricentis.com/101/app.php");
        //driver.Navigate().GoToUrl("http://sampleapp.tricentis.com/101/app.php");
        //driver.Manage().Window.Maximize();


        Thread.Sleep(5000);
        vi.ValidarAberturaPagina();
        
        vi.ValidarTituloPagina("Vehicle Insurance Application");

        // Selecionar Aba
        vi.SelecionarAba("entervehicledata");
        vi.ValidarAbaSelecionada("make");
        //Assert.That(vi.AbaSelecionada, Is.True);
              
        //Preencher Campos - Enter Vehicle Data
        vd.SelecionarMake("Honda");
        vd.SelecionarModel("Scooter");
        vd.PreencherCylinderCapacity("50");
        vd.PreencherEnginePerformance("13");
        vd.PreencherDateOfManufacture("07/23/2024");
        vd.SelecionarNumberOfSeats("2");
        vd.SelecionarRightHandDriveYes();
        vd.SelecionarNumberOfSeatMotorcycle("2");
        vd.SelecionarFuel("Petrol");
        vd.PreencherPayLoad("14");
        vd.PreencherTotalWeight("155");
        vd.PreencherListPrice("1666");
        vd.PreencherLicensePlateNumber("17");
        vd.PreencherAnnualMileAge("188");

        vd.ValidaQtdCamposObrigatorios("0");

        vd.ClicarBotaoNextInsurance();
        vd.ValidarAbaInsurance();

        //Preencher Campos - Enter Insurance Data
        icd.PreencherFisrtName("Jose");
        icd.PreencherLastName("Filho");
        icd.PreencherBirthDate("10/15/1980");
        icd.SelecionarGenderMale();
        icd.PreencherStreetAddress("Rua Amarela");
        icd.SelecionarCountry("Brazil");
        icd.PreencherZipCode("13311151");
        icd.PreencherCity("Boituva");
        icd.SelecionarOccupation("Employee");
        icd.SelecionarSpeeding();
        icd.SelecionarSkydiving();
        icd.PreencherWebSite("https://www.testedosteste.com");

        icd.ClicarBotaoNextProduct();
        
        vi.FecharPagina();
    }
}
