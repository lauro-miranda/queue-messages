using Newtonsoft.Json;
using System;

namespace LM.RabbitMQ.Messages
{
    public class ErrorMessage<TEventMessage> where TEventMessage : IEventMessage
    {
        [JsonConstructor]
        public ErrorMessage(string text
            , DateTime date
            , TEventMessage eventMessage
            , ErrorType type = ErrorType.BusinessError)
        {
            Code = Guid.NewGuid();
            Text = text;
            Date = date;
            EventMessage = eventMessage;
            Type = type;
        }

        public Guid Code { get; private set; }

        public string Text { get; }

        public DateTime Date { get; }

        public ErrorType Type { get; }

        public TEventMessage EventMessage { get; }

        public void ChangeCode(Guid code)
        {
            if (Guid.Empty.Equals(code))
                throw new RabbitMQMessageException("O código não pode ser vazio.");

            Code = code;
        }
    }
}