using System;
using System.Runtime.Serialization;

namespace GooglePhotos.Models
{
    public class MediaItem
    {
        /// <summary>
        /// Identifier for the media item. This is a persistent identifier 
        /// that can be used between sessions to identify this media item.
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Description of the media item. This is shown to the user in the 
        /// item's info section in the Google Photos app.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Google Photos URL for the media item. This link is available to the user only if they're signed in.
        /// </summary>
        [DataMember(Name = "productUrl")]
        public string ProductUrl { get; set; }

        /// <summary>
        /// A URL to the media item's bytes. This shouldn't be used directly to access the media item. 
        /// For example, '=w2048-h1024' will set the dimensions of a media item of type photo to have 
        /// a width of 2048 px and height of 1024 px.
        /// </summary>
        [DataMember(Name = "baseUrl")]
        public string BaseUrl { get; set; }


        /// <summary>
        /// MIME type of the media item. For example, image/jpeg.
        /// </summary>
        [DataMember(Name = "mimeType")]
        public string MimeType { get; set; }

        /// <summary>
        /// Metadata related to the media item, such as, height, width, or creation time.
        /// </summary>
        [DataMember(Name = "mediaMetadata")]
        public MediaMetadata MediaMetadata { get; set; }

        /// <summary>
        /// Information about the user who created this media item.
        /// </summary>
        [DataMember(Name = "contributorInfo")]
        public ContributorInfo ContributorInfo { get; set; }

        /// <summary>
        /// Filename of the media item. This is shown to the user in the item's info section in the Google Photos app.
        /// </summary>
        [DataMember(Name = "filename")]
        public string FileName { get; set; }
    }
}
