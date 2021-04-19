using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Selenium;
using testes;
using Xunit;

namespace Testes
{
    public class Testes
    {
        private IConfiguration _configuration;
        public Testes()
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json");

            _configuration = builder.Build();
        }


        [Fact]
        public void TestarFirefox()
        {
            ExecutaTesteGoogle(Browser.Firefox);
            //var pathDriver = _configuration.GetSection("Selenium:PathDriverFirefox");
            //Assert.Equal().Value);
        }

        [Fact]
        public void TestarChrome()
        {
            ExecutaTesteGoogle(Browser.Chrome);
        }

        private void ExecutaTesteGoogle(Browser browser)
        {
            TesteGoogle testeGoogle = new TesteGoogle(_configuration, browser);
            testeGoogle.CarregarPagina();
            var results = testeGoogle.BuscaGoogle("latam");

            Assert.True(results.Count > 1);
            testeGoogle.FecharPagina();

        }
    }
}
