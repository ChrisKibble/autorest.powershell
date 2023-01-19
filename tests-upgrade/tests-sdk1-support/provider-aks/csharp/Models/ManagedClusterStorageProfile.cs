// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// Storage profile for the container service cluster.
    /// </summary>
    public partial class ManagedClusterStorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterStorageProfile
        /// class.
        /// </summary>
        public ManagedClusterStorageProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterStorageProfile
        /// class.
        /// </summary>
        /// <param name="diskCsiDriver">AzureDisk CSI Driver settings for the
        /// storage profile.</param>
        /// <param name="fileCsiDriver">AzureFile CSI Driver settings for the
        /// storage profile.</param>
        /// <param name="snapshotController">Snapshot Controller settings for
        /// the storage profile.</param>
        /// <param name="blobCsiDriver">AzureBlob CSI Driver settings for the
        /// storage profile.</param>
        public ManagedClusterStorageProfile(ManagedClusterStorageProfileDiskCSIDriver diskCsiDriver = default(ManagedClusterStorageProfileDiskCSIDriver), ManagedClusterStorageProfileFileCSIDriver fileCsiDriver = default(ManagedClusterStorageProfileFileCSIDriver), ManagedClusterStorageProfileSnapshotController snapshotController = default(ManagedClusterStorageProfileSnapshotController), ManagedClusterStorageProfileBlobCSIDriver blobCsiDriver = default(ManagedClusterStorageProfileBlobCSIDriver))
        {
            this.DiskCsiDriver = diskCsiDriver;
            this.FileCsiDriver = fileCsiDriver;
            this.SnapshotController = snapshotController;
            this.BlobCsiDriver = blobCsiDriver;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azureDisk CSI Driver settings for the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskCSIDriver")]
        public ManagedClusterStorageProfileDiskCSIDriver DiskCsiDriver { get; set; }

        /// <summary>
        /// Gets or sets azureFile CSI Driver settings for the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fileCSIDriver")]
        public ManagedClusterStorageProfileFileCSIDriver FileCsiDriver { get; set; }

        /// <summary>
        /// Gets or sets snapshot Controller settings for the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "snapshotController")]
        public ManagedClusterStorageProfileSnapshotController SnapshotController { get; set; }

        /// <summary>
        /// Gets or sets azureBlob CSI Driver settings for the storage profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "blobCSIDriver")]
        public ManagedClusterStorageProfileBlobCSIDriver BlobCsiDriver { get; set; }

    }
}
