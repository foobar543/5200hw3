using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Messages;

namespace Homework3.Middleware
{
    /*An Envelope is a simple wrapper for a message that adds a Public End Point.  For 
    incoming messages, the Public End Point is the sender’s end point. For outgoing 
    messages, the Public End Point it the target receiver.
     */
    class Envelope
    {
		private Message message;
        public Byte[] bytes;
        public Int32 length;
        public IPEndPoint endPoint;

		//TODO: add public end point
		//TODO: add constructor, getters and setters
    }
}
