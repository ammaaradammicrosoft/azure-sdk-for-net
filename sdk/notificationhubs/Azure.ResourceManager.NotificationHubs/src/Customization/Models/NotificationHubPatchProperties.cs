// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using Microsoft.TypeSpec.Generator.Customizations;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    // Backward compatibility: baseline exposes AuthorizationRules as IList<T> (mutable),
    // but the generator produces IReadOnlyList<T> via @@flattenProperty. The underlying
    // ChangeTrackingList<T> implements both interfaces, so this cast is safe.
    [CodeGenSuppress("AuthorizationRules")]
    public partial class NotificationHubPatch
    {
        /// <summary> Gets the AuthorizationRules of the created NotificationHub. </summary>
        public IList<SharedAccessAuthorizationRuleProperties> AuthorizationRules
        {
            get
            {
                if (Properties is null)
                {
                    Properties = new NotificationHubProperties();
                }
                return Properties.AuthorizationRules as IList<SharedAccessAuthorizationRuleProperties>;
            }
        }
    }
}
