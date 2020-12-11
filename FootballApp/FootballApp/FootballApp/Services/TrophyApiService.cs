using FootballApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static FootballApp.Models.Trophy;

namespace FootballApp.Services
{
    public class TrophyApiService : ITrophyApiService
    {
        public async Task<TrophyInfo> GetTrophiesAsync()
        {
            TrophyInfo trophy = null;

            HttpClient  client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v2/trophies/player/276"),
                Headers =
                {
                    { "x-rapidapi-key", "0b61792320msh5d5a0c269f313c6p189d9bjsn72482e737528" },
                    { "x-rapidapi-host", "api-football-v1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                trophy = JsonConvert.DeserializeObject<TrophyInfo>(body);
            }

            return trophy;
        }

        Task ITrophyApiService.GetTrophiesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
