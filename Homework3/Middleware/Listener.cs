using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Messages;

namespace Homework3.Middleware
{
    /*A Listener object is responsible for grabbing messages (and more specifically, envelops 
    containing messages) received by a Communicator (at least the primary communicator) 
    and placing them into a MessageQueue for later processing by a Doer object or its 
    Conversation Execution Strategy objects.  Note that the Listener object does not 
    interpret or process the message beyond checking the message number and conversion 
    id.  If the message number is the same as the conversion id, then the incoming envelop
    is supposed to start a new conversation, so it places it in the Request MessageQueue.
    Otherwise, the message is a following message for an supposedly existing conversation.
    The listener should look to see if there is a Conversation MessageQueue for that conversation
    id, and if there is one, place the envelop in that queue. If there isn’t a Conversion Message
    Queue, then that message is an erroneous message and should be ignored. The Listener object
    is an active object, running on this own thread. It should try to get messages from the
    Communicator as soon as they are available so internal UDP buffers are not overrun.
     */
    
    public class Listener:BackgroundThread
    {
        private Communicator communicator;
        private int port;

        public Listener(Communicator communicator, int port)
        {
            this.communicator = communicator;
            this.port = port;

            communicator.BeginReceive(new AsyncCallback(ReceiveMessage), null);
        }

        public void ReceiveMessage(IAsyncResult result)
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, port);
            byte[] msg = communicator.EndReceive(result, ref remoteIpEndPoint);
            communicator.BeginReceive(new AsyncCallback(ReceiveMessage), null);

            //Do we need to put message in envelope?

            ProcessMessage(msg);
        }

        private void ProcessMessage(byte[] message)
        {
            Message msg = Message.Decode(message);

            //TODO: implement these conditional statements
            if (msg.ConvId == msg.MessageNr)
            {
                //if message number equals conversation id, then start new conversation and place in Request message queue
            }
            //else if converstaion message queue exists for conversation, put message in converstation queue.
            //else, disregard message
        }
    }
}
