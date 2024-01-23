﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mexc.Net.Objects.Models.Spot
{
    /// <summary>
    /// Aggregated trade info
    /// </summary>
    public class MecxAggregatedTrade
    {
        /// <summary>
        /// Trade price
        /// </summary>
        [JsonProperty("p")]
        public decimal Price { get; set; }
        /// <summary>
        /// Trade quantity
        /// </summary>
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        [JsonProperty("T")]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Buyer was maker
        /// </summary>
        [JsonProperty("m")]
        public bool IsBuyerMaker { get; set; }
        /// <summary>
        /// Best price match
        /// </summary>
        [JsonProperty("M")]
        public bool IsBestMatch { get; set; }
    }
}
