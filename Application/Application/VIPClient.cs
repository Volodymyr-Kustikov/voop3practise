namespace ConsoleApp;

public class VipClient : ClientsCounter
{
    public string VipLevel { get; set; }

    public VipClient(string clientName, string clientType, string vipLevel, ILogger logger)
        : base(clientName, clientType, logger)
    {
        VipLevel = vipLevel;
    }

    public override void ShowClientsData()
    {
        _logger.Log($"VIP Client: {ClientName}, Type: {ClientsData}, Level: {VipLevel}");
    }
}