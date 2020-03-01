using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1Apbd
{
    public class Program
    {
        public class Student
        {
            public string Imie { get; set; }


        }
        public static async Task Main(string[] args)
        {
            
            
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode)
            {
                string html = await result.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(html);
                foreach(var m in matches)
                {
                    Console.WriteLine(m.ToString());
                }

                
            }

            /// metody piszemy z duzej litery

            
            //JS promise async/await
            // Java future
            //C# Task async/await


            Console.WriteLine("Hello World!");
        }
    }
}
