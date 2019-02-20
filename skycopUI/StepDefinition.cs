using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser 

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

        [Given(@"I Open sky Cop complain page")]
        public void GivenIOpenSkyCopComplainPage()
        {
            Driver.Url = "https://claim.skycop.com/";
        }

        [Then(@"I enter Kaunas as Departed from")]
        public void ThenIEnterKaunasAsDepartedFrom()
        {
            Thread.Sleep(5000);
            var departureAirportField = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[1]"));
            Thread.Sleep(5000);
                 departureAirportField.SendKeys("Kaunas");
            Thread.Sleep(2000);
            var KaunasAirportSelection = Driver.FindElement(By.XPath("(//div[@title='Kaunas International Airport'])"));
            KaunasAirportSelection.Click();
        }

        [Then(@"I enter London as Arriving airport")]
        public void ThenIEnterLondonAsArrivingAirport()
        {
            var arrivingAirport = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[2]"));
            Thread.Sleep(2000);
            arrivingAirport.SendKeys("London");
            Thread.Sleep(2000);
            var LondonHeatrowAirport = Driver.FindElement(By.XPath("(//div[@title='London Heathrow Airport'])"));
            LondonHeatrowAirport.Click();
        }

        [Then(@"I enter Airlines")]
        public void ThenIEnterAirlines()
        {
            var airlines = Driver.FindElement(By.XPath("(//input[@class='Select-input'])[3]"));
            Thread.Sleep(2000);
            airlines.SendKeys("Lufthansa");
            Thread.Sleep(2000);
            var SelectingLufthansaAirlines = Driver.FindElement(By.XPath("//div[@title='Lufthansa']"));
            SelectingLufthansaAirlines.Click();
        }

        [Then(@"I enter flight Number")]
        public void ThenIEnterFlightNumber()
        {
            var flightnumber = Driver.FindElement(By.XPath("(//input[@name='failedFlightNumberDigits'])"));
            Thread.Sleep(2000);
            flightnumber.SendKeys("0000");
         }

        [Then(@"I enter flight Date")]
        public void ThenIEnterFlightDate()
        {
            var flightDate = Driver.FindElement(By.XPath("(//input[@name='failedFlightDate'])"));
            flightDate.Click();
            var pickflightdate = Driver.FindElement(By.XPath("(//td[@data-value='7'])[1]"));
            pickflightdate.Click();
        }

        [Then(@"I pick flight encountered reason - delayed")]
        public void ThenIPickFlightEncounteredReason_Delayed()
        {
            var flightdelayed = Driver.FindElement(By.XPath("(//span[text()='Flight delayed' and @class])"));
            Thread.Sleep(2000);
            flightdelayed.Click();
        }

        [Then(@"I pich how long flight was late three hours")]
        public void ThenIPichHowLongFlightWasLateThreeHours()
        {
            Thread.Sleep(4000);
            var selektingLessThenThreeHours = Driver.FindElement(By.XPath("(//span[text()='More than 3 hours'])"));
            selektingLessThenThreeHours.Click();
        }
            [Then(@"I provide airlines reason and hear about us info")]
        public void ThenIProvideAirlinesReasonAndHearAboutUsInfo()
        {
            Thread.Sleep(2000);
            var reasonProvidedByAirlines = Driver.FindElement(By.XPath("(//span[@id='react-select-6--value'])"));
            reasonProvidedByAirlines.Click();
            Thread.Sleep(2000);
            var selectingBadWeatherConditions = Driver.FindElement(By.XPath("(//div[text()='Bad weather conditions'])"));
            selectingBadWeatherConditions.Click();

            Thread.Sleep(2000);
            var hearAboutUs = Driver.FindElement(By.XPath("(//span[@id='react-select-7--value'])"));
            hearAboutUs.Click();
            Thread.Sleep(2000);
            var selectingFacebook = Driver.FindElement(By.XPath("(//div[text()='Google ads'])"));
            selectingFacebook.Click();
        }
        [Then(@"presing next page")]
        public void ThenPresingNextPage()
        {
            var nextPage = Driver.FindElement(By.XPath("(//button[@class='sc-jzgbtB fuZkWY sc-lhVmIH hgYwDF'])"));
            nextPage.Click();
        }

        [Then(@"ented situatio description and rezervation number")]
        public void ThenEntedSituatioDescriptionAndRezervationNumber()
        {
            Thread.Sleep(2000);
            var situationDescription = Driver.FindElement(By.XPath("(//textarea [@name='comments'])"));
            situationDescription.SendKeys("Situacija buvo tragiška. Noriu, kad gražintumėte pinigus!!!!");
            Thread.Sleep(2000);
            var RezervationNumber = Driver.FindElement(By.XPath("(//input [@name='bookingNumber'])"));
            RezervationNumber.SendKeys("LTU123");
            var EnterTravelersDetails = Driver.FindElement(By.XPath("(//button[@class='sc-lkqHmb gWdxsM sc-lhVmIH hgYwDF'])"));
            EnterTravelersDetails.Click();
        }

            [Then(@"entering login information")]
        public void ThenEnteringLoginInformation()
        {
            Thread.Sleep(2000);
            var EnterName = Driver.FindElement(By.XPath("(//input[@placeholder='Enter your name'])"));
            EnterName.SendKeys("Edita");
            Thread.Sleep(2000);
            var EnterSurname = Driver.FindElement(By.XPath("(//input[@placeholder='Enter your surname'])"));
            EnterSurname.SendKeys("PerIlga");
            Thread.Sleep(2000);
            var EnterEmail = Driver.FindElement(By.XPath("(//input[@name='userEmail'])"));
            EnterEmail.SendKeys("edita@gmail.com");
            Thread.Sleep(2000);
            var RepeatEmail = Driver.FindElement(By.XPath("(//input[@name='repeatEmail'])"));
            RepeatEmail.SendKeys("edita@gmail.com");
            Thread.Sleep(2000);
            var EnterNumber = Driver.FindElement(By.XPath("(//input[@type='tel'])"));
            Thread.Sleep(2000);
            EnterNumber.SendKeys("01020305");
            Thread.Sleep(2000);

            var PfoneCode = Driver.FindElement(By.XPath("(//input[@name='userPhoneCode'])"));
            PfoneCode.Click();
            Thread.Sleep(2000);
            var EnterCountry = Driver.FindElement(By.XPath("(//span[@id='react-select-9--value'])"));
            Thread.Sleep(2000);
            EnterCountry.SendKeys("Lithuania");
            Thread.Sleep(2000);
            var SelectLithuania = Driver.FindElement(By.XPath("(//input[@value='+370'])"));
            SelectLithuania.Click();

          
            var EnterBirthDate = Driver.FindElement(By.XPath("(//input[@placeholder='Enter birthdate'])"));
            EnterBirthDate.Click();
            var pickBirthDate = Driver.FindElement(By.XPath("()"));
            pickBirthDate.Click();



            Thread.Sleep(2000);
            var FasterLogin = Driver.FindElement(By.XPath("(//a[@class='sc-dliRfk iyBkqV sc-elJkPf kfgeWe'])"));
            FasterLogin.Click();

        }

    }

}