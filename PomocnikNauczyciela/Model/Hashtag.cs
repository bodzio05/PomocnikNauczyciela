using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomocnikNauczyciela.Model
{
    public class Hashtag
    {
        public string Text { get; set; }

        public Hashtag(string text)
        {
            this.Text = text;
        }
    }
}
