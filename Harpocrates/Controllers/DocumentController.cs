using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace Harpocrates.API.Controllers;

[Route("/api/[controller]")]
public class DocumentController : ControllerBase
{
    private readonly ILogger<DocumentController> _logger;
    private readonly CosmosClient _cosmosClient;

    public DocumentController(ILogger<DocumentController> logger, CosmosClient cosmosClient)
    {
        _logger = logger;
        _cosmosClient = cosmosClient;
    }

    [Route("test")]
    public IActionResult Test()
    {
        _logger.Log(LogLevel.Information, "Test endpoint reached");
        _logger.Log(LogLevel.Information, $"connection string: {_cosmosClient.Endpoint}");
        
        return Ok("appel");
        // _cosmosClient.GetDatabase("documents").GetContainer("general").ReadItemAsync<>()
    }
}