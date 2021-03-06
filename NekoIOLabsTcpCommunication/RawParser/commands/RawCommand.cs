﻿using NekoIOLabsTcpCommunication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NekoIOLabsTcpCommunication.RawParser.commands
{
    class RawCommand : IMessage
    {
        public byte[] Serialize()
        {
            return _data;
        }


        private byte[] _data;

        public byte[] Data
        {
            get { return _data; }
            set { _data = value; }
        }


    }
}
