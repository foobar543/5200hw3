using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Homework3.Middleware
{
    /*This class is an abstraction for communicating with other processes via UDP-based 
    messages.  It should handle the basic send and receive operations for Message objects, 
    or more precisely Envelop objects, which are wrappers for Messages with sender or 
    receiver End Points).   Each process in the system will have one Communicator through 
    which it sends and received all messages.
     */
    public class Communicator
    {
        public int Send(Envelope envelope)
        {
            UdpClient udpClient = new UdpClient();
            return udpClient.Send(envelope.bytes, envelope.length, envelope.endPoint);
        }
    }
}
