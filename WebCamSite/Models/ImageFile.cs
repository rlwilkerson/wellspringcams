using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCamSite.Models
{
    public class ImageFile
    {
        public int Id { get; set; }
        public byte[] ImageBytes { get; set; }
        public System.DateTime DateTaken { get; set; }

    }
}