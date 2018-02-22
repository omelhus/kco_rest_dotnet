#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="ShippingOption.cs" company="Klarna AB">
//     Copyright 2018 Klarna AB
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------
#endregion

namespace Klarna.Rest.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// ShippingOptions available
    /// </summary>
    public class ShippingOption
    {
        /// <summary>
        ///     Gets or sets the shipping option id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option price.
        /// </summary>
        [JsonProperty("price")]
        public int? Price { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option tax amount.
        /// </summary>
        [JsonProperty("tax_amount")]
        public int? TaxAmount { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option tax rate.
        /// </summary>
        [JsonProperty("tax_rate")]
        public int? TaxRate { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the shipping options is preselected or not
        /// </summary>
        [JsonProperty("preselected")]
        public bool Preselected { get; set; }

        /// <summary>
        ///     Gets or sets the shipping option shipping method.
        /// </summary>
        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }
    }
}