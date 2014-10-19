using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages;

namespace Homework3.Middleware
{
    /*A MessageQueue object is a queue of messages that have been received by the Listener,
    but not yet processed by a Doer or Conversation Execution Strategy.  Since a process’s
    Listener, Doer, and Conversion Execution Strategies will be running as separate threads, 
    a MessageQueue object must guarantee correct queue behavior in the present of 
    concurrent access.  One MessageQueue will be the Request Message Queue, and others 
    will be Conversation Message Queues.  There will be need to be a way for the Listener to
    know or discover the Request Message Queue and create new Conversation Message Queue.  The Doer will need to know the Request Message, and Conversation Execution 
    Strategies will need to know or discover their respective Conversation Message Queues
    */
    class MessageQueue
    {
    }
}
