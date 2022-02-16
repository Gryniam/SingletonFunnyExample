using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    class Televisor
    {
        int sound = 50;
        int channelIterator = 0;
        bool turn = false;
        Channel currentChannel;
        List<Channel> channels;


        private static Televisor televisor;
        private Televisor()
        {
            channels = initializeChannels();
            currentChannel = channels[channelIterator];
        }

        public static Televisor getInstance()
        {
            if(televisor == null)
            {
                televisor = new Televisor();
                return televisor;
            }
            else
            {
                return televisor;
            }
        }

        List<Channel> initializeChannels()
        {
            string path = Program.pathToFotos;
            List<Channel> l = new List<Channel>();
            l.Add(new Channel("1+1", path + "1+1.jpg"));
            l.Add(new Channel("Інтер", path + "Інтер.jpg"));
            l.Add(new Channel("СТБ", path + "СТБ.jpg"));
            l.Add(new Channel("Україна", path + "Україна.jpg"));
            l.Add(new Channel("Новий канал", path + "Новий канал.jpg"));
            return l;
        }

        public List<Channel> Channels
        {
            get
            {
                return channels;
            }
        }
        public Channel Channel
        {
            get
            {
                return currentChannel;
            }
            set
            {
                if (turn)
                {
                    currentChannel = value;
                }
            }
        }
        public Channel this[int index]
        {
            get
            {
                return channels[index];
            }
            set
            {
                if(value is Channel && turn)
                {
                    channels[index] = value;
                }
            }
        }
        public int Sound
        {
            get
            {
                return sound;
            }
            set
            {
                if (turn)
                {
                    sound = value;
                    if (sound < 0)
                    {
                        sound = 0;
                    }
                    if (sound > 100)
                    {
                        sound = 100;
                    }
                }
            }
        }
        public bool Turn
        {
            get
            {
                return turn;
            }
            set
            {
                turn = value;
            }
        }
        public int ChannelI
        {
            get
            {
                return channelIterator;
            }
            set
            {
                if (turn)
                {
                    channelIterator = value;
                    if (channelIterator < 0)
                    {
                        channelIterator = channels.Count - 1;
                    }
                    if (channelIterator > channels.Count - 1)
                    {
                        channelIterator = 0;
                    }
                }
                
            }
        }
    }
}
