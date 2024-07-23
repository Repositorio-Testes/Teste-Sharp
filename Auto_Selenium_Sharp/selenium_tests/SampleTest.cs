using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium_tests;

public class SampleTest : TestFunctions
{
    [Test]
    [Category("Selenium")]
    public void NavigationTest()
    {
        //Abrir Página
        OpenBrowser("http://sampleapp.tricentis.com/101/app.php");
        Thread.Sleep(5000);
        ValidateText("app_sub_title","Vehicle Insurance Application");
        
        //Validar seleção de tab
        ClickButton("entervehicledata");
        ValidateObjDisplayed("make");
              
        //Preencher Campos - Enter Vehicle Data
        SelectText("make","Honda");
        SelectText("model", "Scooter");
        InputText("cylindercapacity", "12");
        InputText("engineperformance", "13");
        InputText("dateofmanufacture", "07/23/2024");
        SelectText("numberofseats", "2");
        ClickEXpath("//*[@id='insurance-form']/div/section[1]/div[7]/p/label[1]");
        SelectText("numberofseatsmotorcycle", "2");
        SelectText("fuel", "Petrol");
        InputText("payload", "14");
        InputText("totalweight", "155");
        InputText("listprice", "1666");
        InputText("licenseplatenumber", "17");
        InputText("annualmileage", "188");

        ClickButton("nextenterinsurantdata");
        ValidateTextCss("#entervehicledata > span","0");

        //Preencher Campos - Enter Insurance Data
        InputText("firstname", "Jose");
        InputText("lastname", "Filho");
        InputText("birthdate", "10/15/1980");
        ClickEXpath("//*[@id='insurance-form']/div/section[2]/div[4]/p/label[1]");
        InputText("streetaddress", "Rua Amarela");
        SelectText("country", "Brazil");
        InputText("zipcode", "13311151");
        InputText("city", "Boituva");
        SelectText("occupation", "Employee");
        ClickEXpath("//*[@id='insurance-form']/div/section[2]/div[10]/p/label[1]");
        ClickEXpath("//*[@id='insurance-form']/div/section[2]/div[10]/p/label[4]");
        InputText("website", "https://www.testedosteste.com");

        ClickButton("nextenterproductdata");
        
        CloseBrowser();
    }
}
