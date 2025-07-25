using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CarShare.Function;

public class Health
{
    private readonly ILogger<Health> _logger;

    public Health(ILogger<Health> logger)
    {
        _logger = logger;
    }

    [Function("Health")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult($"Yes! The Health function is running at {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss")} UTC.");
    }
}