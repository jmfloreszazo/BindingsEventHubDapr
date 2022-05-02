using PubSubDarpSample.Publisher;

await GenerateGuestActionsMessages("pub-microservice", "mydaprdemoeventhub");

async Task GenerateGuestActionsMessages(string pubSubName, string topic)
{
    var pubService = new EventService();
    await pubService.SendEventMessages(2, pubSubName, topic);
}