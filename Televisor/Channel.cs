using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    class Channel
    {
        string channelName;
        string pathToFoto;

        public Channel(string n, string p)
        {
            this.channelName = n;
            this.pathToFoto = p;
        }
        public string Name
        {
            get
            {
                return channelName;
            }
        }
        public string Path
        {
            get
            {
                return pathToFoto;
            }
        }
        public string Sound
        {
            get
            {
                return sound;
            }
        }
    }
}
