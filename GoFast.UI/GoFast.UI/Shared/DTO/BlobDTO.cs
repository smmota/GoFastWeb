using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFast.UI.Shared.DTO
{
    public class BlobDTO
    {
        public string Name { get; set; }

        public string imagemBase64 { get; set; }

        public string Link { get; set; }

        public BlobDTO(string name, string imagemBase64, string link)
        {
            Name = name;
            this.imagemBase64 = imagemBase64;
            Link = link;
        }

        public BlobDTO()
        {
        }
    }
}
