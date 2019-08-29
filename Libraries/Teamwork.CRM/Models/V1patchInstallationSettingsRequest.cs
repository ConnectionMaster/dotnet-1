// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Teamwork.CRM.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// patchInstallationSettingsRequest
    /// </summary>
    public partial class V1patchInstallationSettingsRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1patchInstallationSettingsRequest class.
        /// </summary>
        public V1patchInstallationSettingsRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1patchInstallationSettingsRequest class.
        /// </summary>
        public V1patchInstallationSettingsRequest(V1patchInstallationSettingsRequestInstallationSettings installationSettings)
        {
            InstallationSettings = installationSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "installationSettings")]
        public V1patchInstallationSettingsRequestInstallationSettings InstallationSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InstallationSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InstallationSettings");
            }
        }
    }
}
