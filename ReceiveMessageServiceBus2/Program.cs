using ReceiveMessageServiceBus2;

const string connectionString = "Namespace connection";
const string topicName = "mytopic";
const string subscriptionName = "consumer2";

ReceiveMessage receiveMessage = new ReceiveMessage();
await receiveMessage.ReceiveMessageFromTopic(connectionString, topicName, subscriptionName);

//Receive messages with service bus processor
await ReceiveMessageProcessor.ReceiveProcessor(connectionString, topicName, subscriptionName);

Console.WriteLine("Received Messsage from topic subscription 2.");
Console.ReadKey();
