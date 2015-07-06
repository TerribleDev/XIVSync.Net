using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using CsQuery;
using CsQuery.ExtensionMethods;
using CsQuery.Web;
using Newtonsoft.Json;
using RestSharp;

namespace XIVSync.Net
{
    public class LodestoneApi
    {
        
        public LodestoneSearch SearchCharacter(string character, string server, int timeout = 90000)
        {
            var client = new RestClient("http://xivsync.com/") {Timeout = timeout};
            var req = new RestRequest("search/character", Method.GET);
            req.AddParameter("name", character);
            req.AddParameter("server", server);
            var response = client.Execute(req);
            return response.StatusCode != HttpStatusCode.OK ? null : JsonConvert.DeserializeObject<LodestoneSearch>(response.Content);
        }

        public LodestoneCharacter GetCharacter(string characterId, int timeout = 90000)
        {
            var client = new RestClient("http://xivsync.com/") {Timeout = timeout};
            var req = new RestRequest("character/get");
            req.AddParameter("lodestone", characterId);
            var response = client.Execute(req);
            return response.StatusCode != HttpStatusCode.OK ? null : JsonConvert.DeserializeObject<LodestoneCharacter>(response.Content);
        }

        public IList<Server> GetServers(double timeoutSeconds = 90)
        {
            var dom = CQ.CreateFromUrl("http://na.finalfantasyxiv.com/lodestone/worldstatus/", new ServerConfig() {TimeoutSeconds =  timeoutSeconds});
            var servers = new List<Server>();
            foreach (var node in dom[".worldstatus_1"])
            {
                var serverName = node.ChildNodes.First(a => a.NodeName == "TD").FirstElementChild.InnerText.Trim();
                var online = node.ChildNodes.Last(a => a.NodeName == "TD").FirstElementChild.InnerText.Trim();
                servers.Add(new Server() {World = serverName, Online = online.Contains("Online")});
                
            }
            return servers;
        }
    }
}
