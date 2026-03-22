// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    // Backward-compat: baseline had AuthorizationRules as IList (not IReadOnlyList).
    // The flatten visitor skips it because AuthorizationRules is a non-nullable collection (no setter).
    public partial class NotificationHubData
    {
        /// <summary> The AuthorizationRules of the created NotificationHub. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public IList<SharedAccessAuthorizationRuleProperties> AuthorizationRules
        {
            get
            {
                if (Properties is null)
                    Properties = new NotificationHubProperties();
                return (IList<SharedAccessAuthorizationRuleProperties>)Properties.AuthorizationRules;
            }
        }
    }
}
