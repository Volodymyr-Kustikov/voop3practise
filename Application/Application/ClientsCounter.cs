namespace ConsoleApp;

public class ClientsCounter
{
    private static int Clients = 0;
    protected string ClientsData = "Regular";
    public string ClientName { get; set; }
    protected readonly ILogger _logger;

    public ClientsCounter(string clientName, ILogger logger)
    {
        Clients++;
        ClientName = clientName;
        _logger = logger;
    }

    public ClientsCounter(string clientName, string clientType, ILogger logger)
    {
        Clients++;
        ClientName = clientName;
        ClientsData = clientType;
        _logger = logger;
    }

    ~ClientsCounter()
    {
        _logger.Log($"Call Finalizer for {ClientName}");
    }

    public static int GetUserCount()
    {
        return Clients;
    }

    public virtual void ShowClientsData()
    {
        _logger.Log($"Client: {ClientName}, Type: {ClientsData}");
    }
}