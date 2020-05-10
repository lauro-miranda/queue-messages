using System.ComponentModel;

namespace LM.RabbitMQ.Messages
{
    public enum ErrorType
    {
        [Description("Business error")]
        BusinessError = 1,
        [Description("Critical error")]
        CriticalError = 2
    }
}