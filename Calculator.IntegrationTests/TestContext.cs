﻿using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using WebCalculator;

namespace Calculator.IntegrationTests
{
    public class TestContext
    {
        private TestServer _server;

        public HttpClient Client { get; private set; }
        public TestContext()
        {
            SetUpClient();
        }

        private void SetUpClient()
        {
           _server=new TestServer(new WebHostBuilder().UseStartup<Startup>());
           Client = _server.CreateClient();
        }
    }
}
