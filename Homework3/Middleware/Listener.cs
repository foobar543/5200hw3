using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Middleware
{
    /*A Listener object is responsible for grabbing messages (and more specifically, envelops 
    containing messages) received by a Communicator (at least the primary communicator) 
    and placing them into a MessageQueue for later processing by a Doer object or its 
    Conversation Execution Strategy objects.  Note that the Listener object does not 
    interpret or process the message beyond checking the message number and conversion 
    id.   If the message number is the same as the conversion id, then the incoming envelop
     */
    class Listener
    {
    }
}
