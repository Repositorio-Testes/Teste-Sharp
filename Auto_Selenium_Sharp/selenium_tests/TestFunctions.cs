using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V125.Profiler;
using OpenQA.Selenium.Support.UI;

public class TestFunctions
{
    IWebDriver driver = new ChromeDriver();

    public void OpenBrowser(string URL)
    {
        driver.Navigate().GoToUrl(URL);
        driver.Manage().Window.Maximize();
    }

    public void CloseBrowser()
    {
        driver.Quit();
    }
    public void SelectText(string ID, string value)
    {
        try
        {
            SelectElement ItemSelect = new SelectElement(driver.FindElement(By.Id(ID)));
            ItemSelect.SelectByValue(value);
            Thread.Sleep(500);
        }catch
        {
            Assert.Fail();
        }
    }

    public void InputText(string ID, string value)
    {
        try
        {
            driver.FindElement(By.Id(ID)).SendKeys(value);
        }catch
        {
            Assert.Fail();
        }
    }

    public void ClickButton(string ID)
    {
        try
        {
            driver.FindElement(By.Id(ID)).Click();
        }catch
        {
            Assert.Fail();
        }
    }

    public void ClickEXpath(string xpath)
    {
        try
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }catch
        {
            Assert.Fail();
        }
    }

    public void ValidateText(string ID, string value)
    {
        try{
            Assert.That(driver.FindElement(By.Id(ID)).Text, Is.EqualTo(value));
        }catch{
            Assert.Fail();
        }
    }
    
    public void ValidateTextCss(string css, string value)
    {
        try{
            Assert.That(driver.FindElement(By.CssSelector(css)).Text, Is.EqualTo(value));
        }catch{
            Assert.Fail();
        }
    }

    public void ValidateObjDisplayed(string ID)
    {
        try{
            Assert.That(driver.FindElement(By.Id(ID)).Displayed, Is.True);
        }catch{
            Assert.Fail();
        }
    }
}