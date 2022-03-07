namespace Cahsul.Infrastructure.MessageBroker;

public class MessageBrokerOptions
{
    public const string SectionKey = nameof(MessageBroker);

    public RabbitMQ RabbitMQ { get; set; } = default!;
    public Kafka Kafka { get; set; } = default!;
    public MB1 MB1 { get; set; } = default!;
    public MB2 MB2 { get; set; } = default!;
    public MB3 MB3 { get; set; } = default!;
}

public class RabbitMQ
{
    public bool Enabled { get; set; }
    public string NganuRabbitMQ { get; set; } = default!;
}

public class Kafka
{
    public bool Enabled { get; set; }
    public string NganuKafka { get; set; } = default!;
}

public class MB1
{
    public bool Enabled { get; set; }
    public string NganuMB1 { get; set; } = default!;
}

public class MB2
{
    public bool Enabled { get; set; }
    public string NganuMB2 { get; set; } = default!;
}

public class MB3
{
    public bool Enabled { get; set; }
    public string NganuMB3 { get; set; } = default!;
}
