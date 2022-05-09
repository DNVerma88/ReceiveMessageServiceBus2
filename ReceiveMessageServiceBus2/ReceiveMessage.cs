using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiveMessageServiceBus2
{
    public class ReceiveMessage
    {
        static string connectionString = "Endpoint=sb://notificationservice0.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=b4ojYUDXIBKvtL6s1IN4JsNHUvG/KGVzIv33ta0nBHg=";

        static string topicName = "notification0";



        public async Task ReceiveMessageFromTopic()
        {
            await using var client = new ServiceBusClient(connectionString);

            ServiceBusReceiver receiver = client.CreateReceiver(topicName,"subscriber2", new ServiceBusReceiverOptions { ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete });

            ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveMessageAsync();

            string body = receivedMessage.Body.ToString();
            Console.WriteLine(body);



            Console.WriteLine("Received Messsage from topic subscription 2.");
            Console.ReadKey();
        }

    }
}
