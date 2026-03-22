// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    // Backward-compat: baseline had a public constructor with AzureLocation,
    // and IsAvailiable/Sku properties with setters. After regen, the generator
    // skips its get-only versions since they exist here.
    public partial class NotificationHubAvailabilityResult
    {
        /// <summary> Initializes a new instance of <see cref="NotificationHubAvailabilityResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubAvailabilityResult(AzureLocation location) : base(location)
        {
        }

        /// <summary> True if the name is available, otherwise false. </summary>
        public bool? IsAvailiable { get; set; }

        /// <summary> The Sku description for a namespace. </summary>
        public NotificationHubSku Sku { get; set; }
    }
}
