using CommandLine;
using KafkaProducerConsole;

Console.WriteLine("Starting Kafka producer");

await Parser.Default.ParseArguments<CommandLineOptions>(args)
                   .WithParsedAsync<CommandLineOptions>(RunAsync);

static async Task RunAsync(CommandLineOptions o)
{
    if (o.Batch)
    {
        Console.WriteLine($"Batching producing enabled. Current Arguments: -b {o.Batch}");
        await BasicBatchProducer.Produce(o.Topic, o.Message);
    }
    else
    {
        Console.WriteLine($"We're going to produce {o.Message} to topic: {o.Topic}");
        await BasicAsyncProducer.Produce(o.Topic, o.Message);
    }
}