﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.
namespace Microsoft.Marketplace.SaaS.SDK.Services.Models
{
    using System.ComponentModel;
    using System.Text.Json.Serialization;
    using System.Collections.Generic;
    /// <summary>
    /// Plan Component Details.
    /// </summary>
    /// <seealso cref="Microsoft.Marketplace.SaasKit.Models.SaaSApiResult" />
    public class PlanComponents
    {

        [JsonPropertyName("recurrentBillingTerms")]
        [DisplayName("recurrentBillingTerms")]
        /// <summary>
        /// Gets or Sets RecurrentBillingTerm
        /// </summary>
        public List<RecurrentBillingTerm> RecurrentBillingTerms { get; set; }


        [JsonPropertyName("meteringDimensions")]
        [DisplayName("meteringDimensions")]
        /// <summary>
        /// Gets or Sets MeteringDimensions
        /// </summary>
        public List<MeteringDimension> MeteringDimensions { get; set; }


        
    }
}
