//using System;
//using Microsoft.Extensions.Configuration;
//using OpenQA.Selenium;
//using selenium;
//using Selenium;
//
//namespace testes.classesBase
//{
//    public class BaseClass
//    {
//        public IConfiguration _configuration;
//        private Browser _browser;
//        public IWebDriver _driver;

//        public BaseClass(IConfiguration configuration, Browser browser)
//        {
//            _configuration = configuration;
//            _browser = browser;

//            string pathDriver = null;

//            switch (_browser)
//            {
//                case Browser.Firefox:
//                    pathDriver = _configuration.GetSection("Selenium:PathDriverFirefox").Value;
//                    break;
//case Browser.Chrome:
//    pathDriver = _configuration.GetSection("Selenium:PathDriverChrome").Value;
//    break;
//            }
//
//            _driver = WebDriverFactory.CreateWebDriver(_browser, pathDriver);
//        }
//
//        public void CarregarPagina()
//        {
//            _driver.AbrirPaginaNavegador(TimeSpan.FromSeconds(5),
//                _configuration.GetSection("Selenium:UrlPadrao").Value);
//        }
//
//        public void FecharPagina()
//        {
//            _driver.Quit();
//            _driver = null;
//        }


//    }
//}
