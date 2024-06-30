using BallBox.Client.Models;
using System.Net.Http.Json;

namespace BallBox.Client.Services
{
    public class PlayerService
    {
        private readonly HttpClient _httpClient;
        public PlayerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task CreatePlayerAsync(Player player)
        {
            try
            {
                int currentPlayerCount = await GetCurrentPlayerCountAsync();
                player.Id = currentPlayerCount + 1;

                var response = await _httpClient.PostAsJsonAsync("https://localhost:7250/api/player", player);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error creating player: " + ex.Message);
            }
        }


        public async Task<int> GetCurrentPlayerCountAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7250/api/player/count");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return int.Parse(content);
        }

        public async Task<List<Player>> GetPlayersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Player>>("https://localhost:7250/api/player");
        }

        public void CalculatePlayerOverall(Player player)
        {
            if (player == null) return;
            if (player.Position == "Goalkeeper")
            {
                player.Overall = player.Goalkeeping;
            }
            player.Overall =
                (player.Attacking + player.Defending
                + player.Speed + player.Dribbling + player.Passing
                + player.Shooting + player.Physical) / 7;
        }
    }
}