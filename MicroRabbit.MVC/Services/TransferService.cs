using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _httpClient;

        public TransferService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Transfer(TransferDTO transferDTO)
        {
            var uri = "http://localhost:5000/api/banking";
            var transferContent = new StringContent(JsonConvert.SerializeObject(transferDTO), Encoding.UTF8
                , "application/json");

            var response = await _httpClient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
