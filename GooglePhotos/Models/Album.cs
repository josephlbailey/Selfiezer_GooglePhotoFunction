using System;
using System.Runtime.Serialization;

namespace GooglePhotos.Models
{
    public class Album
    {
        /// <summary>
        /// [Ouput only] Identifier for the album. This is a persistent identifier that can be used between sessions to 
        /// identify this album.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the album displayed to the user in their Google Photos account. 
        /// This string shouldn't be more than 500 characters.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// [Output only] Google Photos URL for the album. The user needs to be signed in to their Google Photos account
        ///  to access this link.
        /// </summary>
        [DataMember(Name = "productUrl")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// [Output only] True if you can create media items in this album. This field is based on the scopes granted 
        /// and permissions of the album. If the scopes are changed or permissions of the album are changed, this field
        ///  is updated.
        /// </summary>
        [DataMember(Name = "isWriteable")]
        public bool IsWriteable { get; set; }

        /// <summary>
        /// [Output only] The number of media items in the album.
        /// </summary>
        [DataMember(Name = "mediaItemsCount")]
        public int MediaItemsCount { get; set; }

        /// <summary>
        /// [Output only] A URL to the cover photo's bytes. This shouldn't be used as is. Parameters should be appended
        ///  to this URL before use. For example, '=w2048-h1024' sets the dimensions of the cover photo to have a width 
        ///  of 2048 px and height of 1024 px.
        /// </summary>
        [DataMember(Name = "coverPhotoBaseUrl")]
        public string CoverPhotoBaseUrl { get; set; }

        /// <summary>
        /// [Output only] Identifier for the media item associated with the cover photo.
        /// </summary>
        [DataMember(Name = "coverPhotoMediaItemId")]
        public string CoverPhotoMediaItemId { get; set; }
    }
}
