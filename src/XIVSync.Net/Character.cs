using System.Collections.Generic;
using Newtonsoft.Json;

namespace XIVSync.Net
{


    public class Classjob
    {

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("iconTimestamp")]
        public string IconTimestamp { get; set; }

        [JsonProperty("iconQueryString")]
        public string IconQueryString { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public object Level { get; set; }

        [JsonProperty("exp_current")]
        public object ExpCurrent { get; set; }

        [JsonProperty("exp_level")]
        public object ExpLevel { get; set; }

        [JsonProperty("exp_total")]
        public int ExpTotal { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }

        [JsonProperty("real_id")]
        public int RealId { get; set; }
    }
    
    public class Minion
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("iconTimestamp")]
        public string IconTimestamp { get; set; }
    }

    public class Mount
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("iconTimestamp")]
        public string IconTimestamp { get; set; }
    }

    public class Event
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("character_id")]
        public string CharacterId { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("jobclass")]
        public string Jobclass { get; set; }

        [JsonProperty("gained")]
        public string Gained { get; set; }

        [JsonProperty("old")]
        public string Old { get; set; }

        [JsonProperty("new")]
        public string New { get; set; }
    }

    public class Data
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("world")]
        public string World { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("avatarTimestamp")]
        public string AvatarTimestamp { get; set; }

        [JsonProperty("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        [JsonProperty("portraitTimestamp")]
        public string PortraitTimestamp { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("race")]
        public string Race { get; set; }

        [JsonProperty("clan")]
        public string Clan { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("nameday")]
        public string Nameday { get; set; }

        [JsonProperty("guardian")]
        public string Guardian { get; set; }

        [JsonProperty("guardianIcon")]
        public string GuardianIcon { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityIcon")]
        public string CityIcon { get; set; }


    

        [JsonProperty("freeCompany")]
        public string FreeCompany { get; set; }

        [JsonProperty("freeCompanyId")]
        public string FreeCompanyId { get; set; }

        [JsonProperty("freeCompanyIcon")]
        public IList<string> FreeCompanyIcon { get; set; }

        [JsonProperty("classjobs")]
        public IList<Classjob> Classjobs { get; set; }

        [JsonProperty("activeClass")]
        public string ActiveClass { get; set; }

        [JsonProperty("activeJob")]
        public string ActiveJob { get; set; }

        [JsonProperty("activeLevel")]
        public string ActiveLevel { get; set; }

        [JsonProperty("minions")]
        public IList<Minion> Minions { get; set; }

        [JsonProperty("mounts")]
        public IList<Mount> Mounts { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("events")]
        public IList<Event> Events { get; set; }

        [JsonProperty("all50")]
        public bool All50 { get; set; }
    }

    public class LodestoneCharacter
    {

        [JsonProperty("ok")]
        public int Ok { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("log")]
        public object Log { get; set; }
    }

}
