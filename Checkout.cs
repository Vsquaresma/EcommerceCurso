using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MyEcommerce.Checkout
{
    public class Checkout
    {
        private readonly ILogger<Checkout> _logger;

        public Checkout(ILogger<Checkout> logger)
        {
            _logger = logger;
        }

        [Function("Checkout")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
