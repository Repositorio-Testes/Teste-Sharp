using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.Profiler;
using OpenQA.Selenium.Support.UI;

public class PageInsuranceData
{
    IWebDriver driver;

    public PageInsuranceData(IWebDriver driver)
    {
        this.driver = driver;
    }
    public void PreencherFisrtName(string value)
    {
        driver.FindElement(By.Id("firstname")).SendKeys(value);
    }
    
    public void PreencherLastName(string value)
    {
        driver.FindElement(By.Id("lastname")).SendKeys(value);
    }
    
    public void PreencherBirthDate(string value)
    {
        driver.FindElement(By.Id("birthdate")).SendKeys(value);
    }
    
    public void SelecionarGenderMale()
    {
        driver.FindElement(By.XPath("//*[@id='insurance-form']/div/section[2]/div[4]/p/label[1]")).Click();
    }
    
    public void PreencherStreetAddress(string value)
    {
        driver.FindElement(By.Id("streetaddress")).SendKeys(value);
    }
    
    public void SelecionarCountry(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("country")));
        ItemSelect.SelectByValue(value);
    }
    
    public void PreencherZipCode(string value)
    {
        driver.FindElement(By.Id("zipcode")).SendKeys(value);
    }

    public void PreencherCity(string value)
    {
        driver.FindElement(By.Id("city")).SendKeys(value);
    }
    
    public void SelecionarOccupation(string value)
    {
        SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id("occupation")));
        ItemSelect.SelectByValue(value);
    }
    
    public void SelecionarSpeeding()
    {
        driver.FindElement(By.XPath("//*[@id='insurance-form']/div/section[2]/div[10]/p/label[1]")).Click();
    }
    
    public void SelecionarSkydiving()
    {
        driver.FindElement(By.XPath("//*[@id='insurance-form']/div/section[2]/div[10]/p/label[4]")).Click();
    }
    
    public void PreencherWebSite(string value)
    {
        driver.FindElement(By.Id("website")).SendKeys(value);
    }

    public void ClicarBotaoNextProduct()
    {
        driver.FindElement(By.Id("nextenterproductdata")).Click();
    }



}