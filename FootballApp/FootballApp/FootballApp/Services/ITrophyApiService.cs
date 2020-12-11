using FootballApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FootballApp.Models.Trophy;

namespace FootballApp.Services
{
    interface ITrophyApiService
    {
        public interface ITrophyApiService
        {
            public Task<TrophyInfo> GetTrophiesAsync();
        }

        Task GetTrophiesAsync();
    }
}
