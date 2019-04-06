using System;
using System.Runtime.Serialization;

namespace GooglePhotos.Models
{
    public class Photo
    {
        /// <summary>
        /// Brand of the camera with which the photo was taken.
        /// </summary>
        [DataMember(Name = "cameraMake")]
        public string CameraMake { get; set; }

        /// <summary>
        /// Model of the camera with which the photo was taken.
        /// </summary>
        [DataMember(Name = "cameraModel")]
        public string CameraModel { get; set; }

        /// <summary>
        /// Focal length of the camera lens with which the photo was taken.
        /// </summary>
        [DataMember(Name = "focalLength")]
        public double FocalLength { get; set; }

        /// <summary>
        /// Aperture f number of the camera lens with which the photo was taken.
        /// </summary>
        [DataMember(Name = "apertureFNumber")]
        public double ApertureFNumber { get; set; }

        /// <summary>
        /// ISO of the camera with which the photo was taken.
        /// </summary>
        [DataMember(Name = "isoEquivalent")]
        public int IsoEquivalent { get; set; }

        /// <summary>
        /// Exposure time of the camera aperture when the photo was taken.
        /// A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        [DataMember(Name = "exposureTime")]
        public string ExposureTime { get; set; }
    }
}
