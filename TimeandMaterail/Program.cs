using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V117.CacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Open Chrome browser
IWebDriver driver = new ChromeDriver(); //instance of a browser
driver.Manage().Window.Maximize();

//Lunch TurnUp Portal and navigate to the website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//user login
IWebElement usernameTextbox = driver.FindElement(By.XPath("//*[@id='UserName']"));
usernameTextbox.SendKeys("hari");

IWebElement passwordTextbox = driver.FindElement(By.XPath("//*[@id=\"Password\"]"));
passwordTextbox.SendKeys("123123");

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//Navigate to time and material 
IWebElement Administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
Administration.Click();

IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeAndMaterial.Click();

//Add
IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNew.Click();
IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCode.Click();
IWebElement typeCodeTime = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
typeCodeTime.Click();
IWebElement createCode= driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
createCode.SendKeys("HelloTan");   
IWebElement createDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
createDescription.SendKeys("HelloTanDes");
Thread.Sleep(1000);
IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricePerUnit.SendKeys("111");     
IWebElement createSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
createSave.Click();
Thread.Sleep(1000);
//Go to last page
IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();


//Edit
IWebElement editLastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editLastRecord.Click();
Thread.Sleep(1000);
IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
editCode.Clear();
editCode.SendKeys("HelloTan1");
IWebElement editDescription = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
editDescription.Clear();
editDescription.SendKeys("HelloTanDes1");
IWebElement EditSave = driver.FindElement(By.XPath("//*[@id=\"SaveButton\"]"));
EditSave.Click();

Thread.Sleep(1000);
//Go to last page
IWebElement lastPageEdit = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[4]/a[4]/span"));
lastPageEdit.Click();
Thread.Sleep(4000);

//Delete
IWebElement lastPageDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[2]"));
lastPageDelete.Click();
driver.SwitchTo().Alert().Accept();



