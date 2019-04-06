using System;
using System.Runtime.Serialization;

namespace GooglePhotos.Models
{
    public class ContributorInfo
    {
        /// <summary>
        /// Display name of the contributor.
        /// </summary>
        [DataMember(Name = "profilePictureBaseUrl")]
        public string ProfilePictureBaseUrl { get; set; }

        /// <summary>
        /// Display name of the contributor.
        /// </summary>
        [DataMember(Name = "displayName")]
        public string DisplayName { get; set; }
    }
}
