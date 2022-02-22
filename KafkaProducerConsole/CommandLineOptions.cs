using CommandLine;

namespace KafkaProducerConsole;

public class CommandLineOptions
{
    [Option('b', "batch", Required = false, HelpText = "Whether to use batch publishing.")]
    public bool Batch { get; set; }

    [Option('k', "admin", Required = false, HelpText = "Whether to create and use admin client.")]
    public bool Admin { get; set; }

    [Option('m', "message", Required = false, Default = "IB's first Kafka message", HelpText = "Message to produce.")]
    public string Message { get; set; }

    [Option('t', "topic", Required = false, Default = "ibTestTopic", HelpText = "Topic to send messages to.")]
    public string Topic { get; set; }
}