using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Sikuli4Net.sikuli_UTIL;
using Sikuli4Net.sikuli_REST;
using NUnit.Framework;
using System.Drawing;
using System.Text.RegularExpressions;

namespace SikuliTry
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver = null;

        private APILauncher luncher = new APILauncher(true);


        [TestMethod]
        public void CreateFence()
        {
            luncher.Start();

            GetIWebDriver("https://dev.alexswift.com/Account/Login");

            Screen scr = new Screen();

            //Create a Pattern for "Username" field
            Pattern Username = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\UserName.PNG");
            //Waiting for the pattern to appear
            scr.Wait(Username, 500);
            //SendKeys into Username field
            scr.Type(Username, "hari77chandana@gmail.com", KeyModifier.NONE);

            //Create a pattern for "Password" field
            Pattern Password = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\Password.PNG");
            //Wait for the pattern to appear
            scr.Wait(Password, 500);
            //SendKeys into Password field
            scr.Type(Password, "Test_123", KeyModifier.NONE);

            //Pattern to click on Login btn
            Pattern LoginBtn = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\LoginBtn.PNG");
            //Wait for Pattern
            scr.Wait(LoginBtn, 500);
            //Click on Login button
            scr.Click(LoginBtn);
            Console.WriteLine("Login successfull");

            //Click on Geofence Hyperlink
            Pattern Geolink = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\GeofenceLink.PNG");
            //Wait for Pattern
            scr.Wait(Geolink,500);
            //Click on the link
            scr.Click(Geolink);
            Console.WriteLine("Clicked on the Geofence link");

            //Click on AddFence button
            Pattern AddFence = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\AddFence.PNG");
            //Wait for Pattern
            scr.Wait(AddFence,900);
            scr.RightClick(AddFence);
            //Click on AddFence button
            scr.Click(AddFence);

            ////Click on Search button
            //Pattern SearchBtn = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\SearchBtn.PNG");
            ////Wait for Pattern
            //scr.Wait(SearchBtn, 800);
            ////Click on AddFence button
            //scr.Type(SearchBtn,"Auckland,Newzealand",KeyModifier.NONE);



            //Click on Navigate button to draw a fence
            //wait for pattern
            Pattern Navigate = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\Navigate.PNG");
            scr.Wait(Navigate, 500);
            //Click on Square button
            scr.Click(Navigate);
           // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Clicked on the Square button");


            //Click on Square button to draw a fence
            Pattern SquareBtn = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\DrawTool.PNG");
            //wait for pattern
            scr.Wait(SquareBtn,500);
            //Click on Square button
            scr.Click(SquareBtn);

            //Maximise the window
            Pattern Maximise = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\maximise.PNG");
            //wait for pattern
            scr.Wait(Maximise, 500);
            //Click on Square button
            scr.Click(Maximise);

            //Draw a Fence
            Pattern Source = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\Source.PNG");
            //wait for pattern
            //scr.Wait(Source, 500);
            Pattern Destination = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\Destination.PNG");
            //wait for pattern
            //scr.Wait(Destination, 500);

            //Creating Fence by DragDrop operation
            //scr.Exists(Source, 500);
            //Region reg = new Screen();
            //Pattern p = new Pattern("someImage.png");
            //Match m = reg.find(p);
            scr.DragDrop(Source, Destination);

            Pattern minimise = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\minimise.PNG");
            scr.Click(minimise);


            //Click on Save Button
            Pattern SaveBtn = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\SaveBtn.PNG");
            //Wait for the pattern
            scr.Wait(SaveBtn, 500);
            //Click on Save Button
            scr.Click(SaveBtn);

            //Click on confirmation Ok button
            Pattern ConfirmOK = new Pattern(@"C:\Users\chand\Desktop\SikuliTry\SikuliPattens\ConfirmationOK.PNG");
            //Wait for pattern
            scr.Wait(ConfirmOK, 800);
            //Click on OK Button
            scr.Click(ConfirmOK);
            Console.WriteLine("Created the fence successfully");

            driver.Close();

            luncher.Stop();

        }

        //[TestMethod]
        //public void DeleteFence()
        //{
        //    luncher.Start();

        //    GetIWebDriver("https://cobra-dev.azurewebsites.net/Account/Login");

        //    Screen scr = new Screen();



        //    luncher.Stop();
        //}
    
        private void GetIWebDriver(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);
        }
    }
}
