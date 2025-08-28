using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        //launch chrome for open browser
        IWebDriver driver = new ChromeDriver();
       
            //Navigate to URL
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Maximize the window
            driver.Manage().Window.Maximize();

            //Enter the username
            IWebElement username = driver.FindElement(By.Id("UserName"));
            username.SendKeys("hari");
            username.Click();

            //Enter the password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");
            password.Click();

            //Click on login button
            IWebElement Loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            Loginbutton.Click();

             //Go to StaffCalendar page
             IWebElement staffcalendar = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[4]/a"));
            

             //click on the month button
             IWebElement monthbutton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[4]/a"));
             monthbutton.Click();

            //Locate search textbox
            IWebElement searchbox = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[1]/div[1]"));
            searchbox.Click();
            Thread.Sleep(2000);
        
            // step1 click on the dropdown to display options
            IWebElement selectstaff = driver.FindElement(By.Id("StaffList")); // visible div
            

            //step2 select the option from the dropdown
            IWebElement selectoption = driver.FindElement(By.Id("scheduler"));
             selectoption.Click();

        //successfully selected the staff from dropdown
        try
        {
            IWebElement option = driver.FindElement(By.XPath("//*[@id=\"StaffList_listbox\"]/li[3]"));
           Console.WriteLine("Ray Raya' found and clicked!");
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine( "Ray Raya' not found in the list.");
        }







        driver.Quit();
        }
        }
            
        
    



            

