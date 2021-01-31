using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Result
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("seller")]
        public Seller Seller { get; set; }

        [JsonPropertyName("price")]
        public float Price { get; set; }

        //[JsonPropertyName("prices")]
        //public List<Price> Prices { get; set; }

        [JsonPropertyName("sale_price")]
        public object SalePrice { get; set; }

        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }

        [JsonPropertyName("available_quantity")]
        public int AvailableQuantity { get; set; }

        [JsonPropertyName("sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonPropertyName("buying_mode")]
        public string BuyingMode { get; set; }

        [JsonPropertyName("listing_type_id")]
        public string ListingTypeId { get; set; }

        [JsonPropertyName("stop_time")]
        public DateTime StopTime { get; set; }

        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        [JsonPropertyName("permalink")]
        public string Permalink { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonPropertyName("accepts_mercadopago")]
        public bool AcceptsMercadopago { get; set; }

        [JsonPropertyName("installments")]
        public Installments Installments { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }

        [JsonPropertyName("seller_address")]
        public SellerAddress SellerAddress { get; set; }

        [JsonPropertyName("attributes")]
        public List<Attribute> Attributes { get; set; }

        [JsonPropertyName("original_price")]
        public int? OriginalPrice { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        [JsonPropertyName("official_store_id")]
        public int? OfficialStoreId { get; set; }

        [JsonPropertyName("domain_id")]
        public string DomainId { get; set; }

        [JsonPropertyName("catalog_product_id")]
        public string CatalogProductId { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("catalog_listing")]
        public bool CatalogListing { get; set; }

        [JsonPropertyName("order_backend")]
        public int OrderBackend { get; set; }

        [JsonPropertyName("differential_pricing")]
        public DifferentialPricing DifferentialPricing { get; set; }
    }

}