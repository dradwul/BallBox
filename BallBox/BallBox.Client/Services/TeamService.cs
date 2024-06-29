using BallBox.Client.Models;
using System.Net.Http.Json;

namespace BallBox.Client.Services
{
    public class TeamService
	{
		private readonly HttpClient _httpClient;
		public TeamService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task CreateTeamAsync(Team team)
		{
			int currentTeamCount = await GetCurrentTeamCountAsync();
			team.Id = currentTeamCount + 1;

			var response = await _httpClient.PostAsJsonAsync("https://localhost:7250/api/team", team);
			response.EnsureSuccessStatusCode();
		}

		public async Task<int> GetCurrentTeamCountAsync()
		{
            var response = await _httpClient.GetAsync("https://localhost:7250/api/team/count");
			response.EnsureSuccessStatusCode();

			var content = await response.Content.ReadAsStringAsync();
			return int.Parse(content);
        }

        public async Task<List<Team>> GetTeamsAsync()
        {
			return await _httpClient.GetFromJsonAsync<List<Team>>("https://localhost:7250/api/team");
        }
    }
}
