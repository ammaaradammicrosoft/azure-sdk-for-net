// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    // Backward-compat: baseline had a public constructor with AzureLocation.
    public partial class NotificationHubTestSendResult
    {
        /// <summary> Initializes a new instance of <see cref="NotificationHubTestSendResult"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubTestSendResult(AzureLocation location) : base(location)
        {
        }
    }
}
