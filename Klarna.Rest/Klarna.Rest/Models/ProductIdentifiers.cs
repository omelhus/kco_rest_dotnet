#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="ProductIdentifiers.cs" company="Klarna AB">
//     Copyright 2014 Klarna AB
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
    /// Product identifiers data model.
    /// </summary>
    public class ProductIdentifiers
    {
        /// <summary>
        /// Gets or sets the category path for the inventory item. E.g. Electronics Store > Computers &amp; Tablets > Desktops.
        /// </summary>
        [JsonProperty("category_path")]
        public string CategoryPath { get; set; }

        /// <summary>
        /// Gets or sets the GTIN for the inventory item
        /// </summary>
        [JsonProperty("global_trade_item_number")]
        public string GlobalTradeItemNumber { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer part number
        /// </summary>
        [JsonProperty("manufacturer_part_number")]
        public string ManufacturerPartNumber { get; set; }

        /// <summary>
        /// Gets or sets the brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }
    }
}