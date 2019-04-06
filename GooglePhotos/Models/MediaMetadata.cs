using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace GooglePhotos.Models
{
    public class MediaMetadata
    {
        private DateTime _creationTime;

        /// <summary>
        /// Time when the media item was first created (not when it was uploaded to Google Photos).
        ///A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds.Example: "2014-10-02T15:01:23.045123456Z".
        /// </summary>
        [DataMember(Name = "creationTime")]
        public string CreationTime
        {
            get => _creationTime.ToString();
            set => _creationTime = DateTime.ParseExact(value, "o", CultureInfo.InvariantCulture, DateTimeStyles.None);
        }

        /// <summary>
        /// Original width (in pixels) of the media item.
        /// </summary>
        [DataMember(Name = "width")]
        public string Width { get; set; }

        /// <summary>
        /// Original height (in pixels) of the media item.
        /// </summary>
        [DataMember(Name = "height")]
        public string Height { get; set; }

        /// <summary>
        /// Metadata for a photo media type.
        /// </summary>
        [DataMember(Name = "photo")]
        public Photo Photo { get; set; }
    }
}
