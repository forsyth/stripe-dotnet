namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Person : StripeEntity, IHasId, IHasObject
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("account")]
        public string AccountId { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("address_kana")]
        public AddressJapan AddressKana { get; set; }

        [JsonProperty("address_kanji")]
        public AddressJapan AddressKanji { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }

        [JsonProperty("dob")]
        public BirthDay Dob { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        [JsonProperty("relationship")]
        public Relationship Relationship { get; set; }

        [JsonProperty("requirements")]
        public Requirements Requirements { get; set; }

        [JsonProperty("ssn_last_4_provided")]
        public bool SsnLast4Provided { get; set; }

        [JsonProperty("verification")]
        public LegalEntityVerification Verification { get; set; }
    }
}
