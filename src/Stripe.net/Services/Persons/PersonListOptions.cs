namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonListOptions : ListOptions
    {
        [JsonProperty("director")]
        public bool? Director { get; set; }

        [JsonProperty("executive")]
        public bool? Executive { get; set; }

        [JsonProperty("owner")]
        public bool? Owner { get; set; }
    }
}
