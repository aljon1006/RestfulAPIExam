using ExamPractice1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ExamPractice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadRainController : ControllerBase
    {
        private readonly ILogger<ReadRainController> _logger;
        private readonly HttpClient client;
        RainFallMeasurement? rainfallMeasurement = null;
        public ReadRainController(ILogger<ReadRainController> logger)
        {
            _logger = logger;
            client = new HttpClient();
        }

        [HttpGet(Name = "rainforecast")]
        public async Task<JsonResult> GetRainForecast()
        {
            try
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string url = "https://environment.data.gov.uk/flood-monitoring/id/stations/3680/measures";

  
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    rainfallMeasurement = JsonConvert.DeserializeObject<RainFallMeasurement>(result);
                    _logger.LogInformation($"Test {JsonConvert.SerializeObject(rainfallMeasurement.Items.Count)}");

                }
                else
                {
                    return new JsonResult("Error occurred while fetching data: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred: {ex.Message}");
                return new JsonResult("Error occurred while fetching data") { StatusCode = 500 };
            }
            return new JsonResult(rainfallMeasurement);
        }
    }
}
