namespace SimpleTestProject.Hooks
{
    using BoDi;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using TechTalk.SpecFlow;

    [Binding]
    public class DriverSetup
    {
        private IObjectContainer _objectContainer;
        public IWebDriver Driver;

        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
           // Driver = new FirefoxDriver();
            _objectContainer.RegisterInstanceAs(Driver);
        }

    }
}

