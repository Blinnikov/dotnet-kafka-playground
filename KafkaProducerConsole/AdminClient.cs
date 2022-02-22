using System.Text.Json;
using Confluent.Kafka;

public class AdminClient
{
    public static async Task Run()
    {

        var adminConfig = new AdminClientConfig()
        {
            BootstrapServers = "localhost:9092"
        };

        using (var adminClient = new AdminClientBuilder(adminConfig).Build())
        {
            var metadata = adminClient.GetMetadata(TimeSpan.FromSeconds(10));
            var topicsMetadata = metadata.Topics;
            var brokersMetadata = JsonSerializer.Serialize(metadata.Brokers);
            Console.WriteLine("Brokers: ");
            Console.WriteLine(brokersMetadata);
        }
    }
}