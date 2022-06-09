using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Darts.MAUI.App.Services
{
    public static class AuthService
    {
        public static async Task<bool> Login(string username, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var resp = await client.GetAsync("posts/10");

                    //resp.EnsureSuccessStatusCode(); // throws error if no success status code
                    if (resp.IsSuccessStatusCode) { 
                    var result = await resp.Content.ReadAsStringAsync();

                    Console.WriteLine("test");

                    return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

            }
        }
    }
}
