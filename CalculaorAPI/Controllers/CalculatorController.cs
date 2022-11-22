using CalculaorAPI.Calculator.Middleware;
using CalculaorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculaorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "Addition")]
        public async Task<ActionResult<double>> Add(string param1, string param2, string operationType)
        {
            _logger.LogInformation($"{ param1  + param2}");

            var calc = new Calculate() { OperationType = "Add", Param1 = param1, Param2 = param2 };
            return await calc.Execute();
        }

        [HttpGet(Name = "Subtraction")]
        public async Task<ActionResult<double>> Subtract(string param1, string param2, string operationType)
        {
            _logger.LogInformation($"{ param1 + param2}");

            var calc = new Calculate() { OperationType = "Subtract", Param1 = param1, Param2 = param2 };
            return await calc.Execute();
        }

        [HttpGet(Name = "Multiplication")]
        public async Task<ActionResult<double>> Multiply(string param1, string param2, string operationType)
        {
            _logger.LogInformation($"{ param1 + param2}");

            var calc = new Calculate() { OperationType = "Multiply", Param1 = param1, Param2 = param2 };
            return await calc.Execute();
        }


        [HttpGet(Name = "Division")]
        public async Task<ActionResult<double>> Divide(string param1, string param2, string operationType)
        {
            _logger.LogInformation($"{ param1 + param2}");

            var calc = new Calculate() { OperationType = "Divide", Param1 = param1, Param2 = param2 };
            return await calc.Execute();
        }
    }
}