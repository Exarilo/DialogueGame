using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuRonron
{

    public class DiscordGuild
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class DiscordChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }

    public class Message
    {
        public string id { get; set; }
        public int type { get; set; }
        public string content { get; set; }
        public Author author { get; set; }
    }
    public class Author
    {
        public string id { get; set; }
        public string username { get; set; }
        public string avatar { get; set; }
    }
}
