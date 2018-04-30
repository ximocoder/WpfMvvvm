using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitleDownloader.Models
{
    public class Subtitle
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }

        public Subtitle()
        {
            this.Name = "test";
            this.Language = "ES";
            this.Type = "sub";
            this.Content = "bla bla bla bla";
        }
    }
}
