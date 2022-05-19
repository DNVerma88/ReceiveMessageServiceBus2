using Azure.Messaging.ServiceBus;

namespace ReceiveMessageServiceBus2
{
    public class ReceiveMessage
    {
        public async Task ReceiveMessageFromTopic(string connectionString, string topicName, string subscriptionName)
        {
            await using var client = new ServiceBusClient(connectionString);
            ServiceBusReceiver receiver = client.CreateReceiver(topicName, subscriptionName, new ServiceBusReceiverOptions { ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete });
            ServiceBusReceivedMessage receivedMessage = await receiver.ReceiveMessageAsync();
            string body = receivedMessage.Body.ToString();
            Console.WriteLine(body);
        }
    }
}
