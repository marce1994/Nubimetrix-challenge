using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Seller
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("registration_date")]
        public DateTime RegistrationDate { get; set; }

        [JsonProperty("car_dealer")]
        public bool CarDealer { get; set; }

        [JsonProperty("real_estate_agency")]
        public bool RealEstateAgency { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("seller_reputation")]
        public object SellerReputation { get; set; }

        [JsonProperty("eshop")]
        public object Eshop { get; set; }
    }
}