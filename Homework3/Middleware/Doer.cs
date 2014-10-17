using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Middleware
{
    /*A Doer is an active object that takes messages out of Request MessageQueue and starts 
    the appropriate Conversation Execution Strategy for handling the processing of the 
    request and the rest of the conversation (e.g., subsequent communications) as defined 
    by the communication protocols.   A Conversation Execution Strategy could be base class 
    or interface in an implementation of the GoF (Gang-of-Four) Strategy Design Pattern.   
    Specializations of this base class are specific to an agent and part of the Application 
    Layer logic for the agent.  By using a Strategy Design Pattern, the Doer doesn’t actually 
    have to know the logic for following the protocols.  Initialization code for an agent can 
    create specializations of the Conversation Execution Strategy and given them to Doer to 
    user.  The Doer simply needs to choose the right concrete strategy object based on 
    message type.  In other words, the Doers should contain as subparts one or more 
    concrete Conversation Execution Strategy objects (one for each message type it has to 
    handle).  The classes for those concrete strategy objects should be defined and created 
    in application-layer components, not the Common library
     */
    class Doer
    {
    }
}
