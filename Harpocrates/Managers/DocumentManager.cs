using Microsoft.Azure.Cosmos;

namespace Harpocrates.API.Managers;

public class DocumentManager
{
    private CosmosClient _cosmosClient;
    
    public DocumentManager(CosmosClient cosmosClient)
    {
        _cosmosClient = cosmosClient;
    }
}