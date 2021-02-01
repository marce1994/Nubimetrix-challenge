using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace WebApi.Services.Dto.MercadoLibre.Search
{

    public class Result
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("seller")]
        public Seller Seller { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("prices")]
        public object Prices { get; set; }

        [JsonProperty("sale_price")]
        public object SalePrice { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("available_quantity")]
        public int AvailableQuantity { get; set; }

        [JsonProperty("sold_quantity")]
        public int SoldQuantity { get; set; }

        [JsonProperty("buying_mode")]
        public string BuyingMode { get; set; }

        [JsonProperty("listing_type_id")]
        public string ListingTypeId { get; set; }

        [JsonProperty("stop_time")]
        public DateTime StopTime { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("permalink")]
        public string Permalink { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("accepts_mercadopago")]
        public bool AcceptsMercadopago { get; set; }

        [JsonProperty("installments")]
        public object Installments { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("shipping")]
        public object Shipping { get; set; }

        [JsonProperty("seller_address")]
        public object SellerAddress { get; set; }

        [JsonProperty("attributes")]
        public List<object> Attributes { get; set; }

        [JsonProperty("original_price")]
        public int? OriginalPrice { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("official_store_id")]
        public int? OfficialStoreId { get; set; }

        [JsonProperty("domain_id")]
        public string DomainId { get; set; }

        [JsonProperty("catalog_product_id")]
        public string CatalogProductId { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("catalog_listing")]
        public bool CatalogListing { get; set; }

        [JsonProperty("order_backend")]
        public int OrderBackend { get; set; }

        [JsonProperty("differential_pricing")]
        public object DifferentialPricing { get; set; }
    }

}