using MassTransit;
using MassTransit.Transports;
using MassTransitAzureSender;

namespace MassTransitAzureReceiver
{
    public class SendMessageConsumer : IConsumer<SendMessageEvent>
    {
        public async Task Consume(ConsumeContext<SendMessageEvent> context)
        {
            try
            {
                var msg = context.Message.MessageBody;

                Console.WriteLine("message received by receiver num 1 : "+msg);

                //_msgService.RespondMessage(msg);
            }
            catch (Exception ex)
            {
                var exMsg = ex.Message;
                throw;
            }
           


        }
    }
}
