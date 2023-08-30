using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;

namespace Harpocrates.API.Controllers;

[Route("/api/[controller]")]
public class DocumentController : ControllerBase
{
    private readonly CosmosClient _cosmosClient;

    public DocumentController(CosmosClient cosmosClient)
    {
        _cosmosClient = cosmosClient;
    }

    [Route("test")]
    public IActionResult Test()
    {
        return Ok();
        // _cosmosClient.GetDatabase("documents").GetContainer("general").ReadItemAsync<>()
    }
}