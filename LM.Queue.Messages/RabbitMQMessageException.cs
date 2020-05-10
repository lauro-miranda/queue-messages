using System;

namespace LM.RabbitMQ.Messages
{
    public class RabbitMQMessageException : Exception
    {
        internal RabbitMQMessageException(string message) : base(message) { }
    }
}