using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace XIVSync.Net
{
    public class LodestoneApi
    {
        readonly RestClient _client = new RestClient("http://xivsync.com/");
        public LodestoneSearch SearchCharacter(string character, string server)
        {
            
            var req = new RestRequest("search/character", Method.GET);
            req.AddParameter("name", character);
            req.AddParameter("server", server);
            var response = _client.Execute(req);
            return response.StatusCode != HttpStatusCode.OK ? null : JsonConvert.DeserializeObject<LodestoneSearch>(response.Content);
        }

        public LodestoneCharacter GetCharacter(string characterId)
        {
            var req = new RestRequest("character/get");
            req.AddParameter("lodestone", characterId);
            var response = _client.Execute(req);
            return response.StatusCode != HttpStatusCode.OK ? null : JsonConvert.DeserializeObject<LodestoneCharacter>(response.Content);
        }
    }
}
