using System.Collections.Generic;
using Newtonsoft.Json;

namespace XIVSync.Net
{
    public class Datum
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("world")]
        public string World { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class LodestoneSearch
    {

        [JsonProperty("ok")]
        public int Ok { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }

        [JsonProperty("log")]
        public object Log { get; set; }
    }

}
