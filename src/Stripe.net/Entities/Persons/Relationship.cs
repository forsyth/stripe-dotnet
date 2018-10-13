namespace Stripe
{
    using Newtonsoft.Json;

    public class Relationship : StripeEntity
    {
        [JsonProperty("controller")]
        public bool Controller { get; set; }

        [JsonProperty("director")]
        public bool Director { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("owner")]
        public bool Owner { get; set; }

        [JsonProperty("percent_ownership")]
        public decimal? PercentOwnership { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("representative")]
        public bool Representative { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
