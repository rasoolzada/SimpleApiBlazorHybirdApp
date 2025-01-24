using SimpleApiBlazorHybirdApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApiBlazorHybirdApp.Services
{
    public class MonkeyService
    {
        private readonly HttpClient _httpClient;
        public MonkeyService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<Monkey>> GetMonkeys()
        {
            var response = await _httpClient.GetAsync("https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json");
            if (response.IsSuccessStatusCode)
            {
                List<Monkey>? monkeys = await response.Content.ReadFromJsonAsync<List<Monkey>>();
                if(monkeys != null)
                {
                    return monkeys;
                }
            }

            return new List<Monkey>();
        }
    }
}
