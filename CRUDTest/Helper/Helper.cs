using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRUDTest.Helper
{
    public class StudentAPI
    {
        public HttpClient Initial()
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://localhost:5001/");
            return Client;
        }
    }
}
