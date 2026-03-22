// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.ComponentModel;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    // Backward-compat: baseline had flattened credential properties + Sku on NotificationHubPnsCredentials.
    // The new generator wraps credentials under Properties (PnsCredentials) and removed Sku.
    // This partial class exposes the flattened properties and Sku for backward compat.
    public partial class NotificationHubPnsCredentials
    {
        /// <summary> Initializes a new instance of <see cref="NotificationHubPnsCredentials"/>. </summary>
        /// <param name="location"> The location. </param>
        public NotificationHubPnsCredentials(AzureLocation location) : base(location)
        {
            Properties = new PnsCredentials();
        }

        /// <summary> The sku of the created namespace. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubSku Sku { get; set; }

        /// <summary> The AdmCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubAdmCredential AdmCredential
        {
            get => Properties?.AdmCredential;
            set => Properties.AdmCredential = value;
        }

        /// <summary> The ApnsCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubApnsCredential ApnsCredential
        {
            get => Properties?.ApnsCredential;
            set => Properties.ApnsCredential = value;
        }

        /// <summary> The BaiduCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubBaiduCredential BaiduCredential
        {
            get => Properties?.BaiduCredential;
            set => Properties.BaiduCredential = value;
        }

        /// <summary> The GcmCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubGcmCredential GcmCredential
        {
            get => Properties?.GcmCredential;
            set => Properties.GcmCredential = value;
        }

        /// <summary> The MpnsCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubMpnsCredential MpnsCredential
        {
            get => Properties?.MpnsCredential;
            set => Properties.MpnsCredential = value;
        }

        /// <summary> The WnsCredential. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public NotificationHubWnsCredential WnsCredential
        {
            get => Properties?.WnsCredential;
            set => Properties.WnsCredential = value;
        }
    }
}
