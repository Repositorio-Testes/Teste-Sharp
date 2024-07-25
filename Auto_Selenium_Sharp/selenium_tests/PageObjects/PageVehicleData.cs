using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.Profiler;
using OpenQA.Selenium.Support.UI;
using System;

public class PageVehicleData
{
    IWebDriver driver;

    public PageVehicleData(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void SelecionarMake(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("make")));
        ItemSelect.SelectByValue(value);
    }

    public void SelecionarModel(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("model")));
        ItemSelect.SelectByValue(value);
    }

    public void PreencherCylinderCapacity(string value)
    {
        driver.FindElement(By.Id("cylindercapacity")).SendKeys(value);;
    }

    public void PreencherEnginePerformance(string value)
    {
        driver.FindElement(By.Id("engineperformance")).SendKeys(value);;
    }

    public void PreencherDateOfManufacture(string value)
    {
        driver.FindElement(By.Id("dateofmanufacture")).SendKeys(value);;
    }

    public void SelecionarNumberOfSeats(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("numberofseats")));
        ItemSelect.SelectByValue(value);
    }

    public void SelecionarRightHandDriveYes()
    {
        driver.FindElement(By.XPath("//*[@id='insurance-form']/div/section[1]/div[7]/p/label[1]")).Click();
    }

    public void SelecionarNumberOfSeatMotorcycle(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("numberofseatsmotorcycle")));
        ItemSelect.SelectByValue(value);
    }

    public void SelecionarFuel(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("fuel")));
        ItemSelect.SelectByValue(value);
    }

    public void PreencherPayLoad(string value)
    {
        driver.FindElement(By.Id("payload")).SendKeys(value);;
    }

    public void PreencherTotalWeight(string value)
    {
        driver.FindElement(By.Id("totalweight")).SendKeys(value);;
    }

    public void PreencherListPrice(string value)
    {
        driver.FindElement(By.Id("listprice")).SendKeys(value);;
    }

    public void PreencherLicensePlateNumber(string value)
    {
        driver.FindElement(By.Id("licenseplatenumber")).SendKeys(value);;
    }

    public void PreencherAnnualMileAge(string value)
    {
        driver.FindElement(By.Id("annualmileage")).SendKeys(value);;
    }

    public void ClicarBotaoNextInsurance()
    {
        driver.FindElement(By.Id("nextenterinsurantdata")).Click();
        Thread.Sleep(500);
    }

    public void ValidarAbaInsurance()
    {
        Assert.That(driver.FindElement(By.Id("firstname")).Displayed, Is.True);
    }

    public void ValidaQtdCamposObrigatorios(string value)
    {
        Assert.That(driver.FindElement(By.CssSelector("#entervehicledata > span")).Text, Is.EqualTo(value));
    }

}
