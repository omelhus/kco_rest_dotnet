﻿#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="MerchantUrls.cs" company="Klarna AB">
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
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The merchant URLs.
    /// </summary>
    public class MerchantUrls : Model
    {
        /// <summary>
        /// Gets or sets the terms.
        /// </summary>
        [JsonProperty("terms")]
        public Uri Terms { get; set; }

        /// <summary>
        /// Gets or sets the checkout.
        /// </summary>
        [JsonProperty("checkout")]
        public Uri Checkout { get; set; }

        /// <summary>
        /// Gets or sets the confirmation.
        /// </summary>
        [JsonProperty("confirmation")]
        public Uri Confirmation { get; set; }

        /// <summary>
        /// Gets or sets the push.
        /// </summary>
        [JsonProperty("push")]
        public Uri Push { get; set; }

        /// <summary>
        /// Gets or sets the validation.
        /// </summary>
        [JsonProperty("validation")]
        public Uri Validation { get; set; }

        /// <summary>
        /// Gets or sets the shipping option update url.
        /// </summary>
        [JsonProperty("shipping_option_update")]
        public Uri ShippingOptionUpdate { get; set; }

        /// <summary>
        /// Gets or sets the address update url.
        /// </summary>
        [JsonProperty("address_update")]
        public Uri AddressUpdate { get; set; }

        /// <summary>
        /// Gets or sets the notification url.
        /// </summary>
        [JsonProperty("notification")]
        public Uri Notification { get; set; }

        /// <summary>
        /// Gets or sets the shipping address update url.
        /// </summary>
        [JsonProperty("shipping_address_update")]
        public Uri ShippingAddressUpdate { get; set; }
    }
}
