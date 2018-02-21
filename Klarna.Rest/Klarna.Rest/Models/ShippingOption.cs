using Newtonsoft.Json;

namespace Klarna.Rest.Models
{
    public class ShippingOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("price")]
        public int? Price { get; set; }
        
        [JsonProperty("tax_amount")]
        public int? TaxAmount { get; set; }
        [JsonProperty("tax_rate")]
        public int? TaxRate { get; set; }
        [JsonProperty("preselected")]
        public bool Preselected { get; set; }
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }
    }
}