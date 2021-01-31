using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Seller
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        [JsonPropertyName("registration_date")]
        public DateTime RegistrationDate { get; set; }

        [JsonPropertyName("car_dealer")]
        public bool CarDealer { get; set; }

        [JsonPropertyName("real_estate_agency")]
        public bool RealEstateAgency { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("seller_reputation")]
        public SellerReputation SellerReputation { get; set; }

        [JsonPropertyName("eshop")]
        public Eshop Eshop { get; set; }
    }

}