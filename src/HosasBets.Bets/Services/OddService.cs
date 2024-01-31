using System.Net.Http;
namespace HosasBets.Bets.Services;

public class OddService : IOddService
{
    private readonly HttpClient _client;
    public OddService(HttpClient client)
    {
        _client = client;
    }

    public async Task<object> UpdateOdd(int MatchId, int TeamId, decimal BetValue)
    {
        var path = $"Odd/{MatchId}/{TeamId}/{BetValue}";
        var newRequest = new HttpRequestMessage(HttpMethod.Patch, new
        Uri(path));

        var response = await _client.SendAsync(newRequest);
        var responseJson = await response.Content.ReadFromJsonAsync<object>();
        return responseJson;
    }
}