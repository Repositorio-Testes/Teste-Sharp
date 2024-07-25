using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.Profiler;
using OpenQA.Selenium.Support.UI;

public class PageVehicleInsuranceApp
{
    IWebDriver driver;

    public PageVehicleInsuranceApp(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void AbrirPagina(string value)
    {
        driver.Navigate().GoToUrl(value);
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);
    }

    public void FecharPagina()
    {
        driver.Quit();
    }

    public void SelecionarAba(string value)
    {
        driver.FindElement(By.Id(value)).Click();
        Thread.Sleep(500);
    }

    public void ValidarAbaSelecionada(string ID)
    {
        Assert.That(driver.FindElement(By.Id(ID)).Displayed, Is.True);
    }

    public void ValidarTituloPagina(string value)
    {
        Assert.That(driver.FindElement(By.Id("app_sub_title")).Text, Is.EqualTo(value));
    }

    public void ValidarAberturaPagina()
    {
        Assert.That(driver.FindElement(By.Id("app_sub_title")).Displayed, Is.True);
    }
}
