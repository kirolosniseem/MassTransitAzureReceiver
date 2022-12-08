using MassTransit;
using MassTransit.Transports;
using MassTransitAzureSender;

namespace MassTransitAzureReceiver
{
    public class SendMessageModelConsumer : IConsumer<SendMessageModel>
    {
        public async Task Consume(ConsumeContext<SendMessageModel> context)
        {
            try
            {
                var msg = context.Message.MessageBody;

                Console.WriteLine("sent message received by receiver num 1 (reading from the queue) : "+msg);

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
