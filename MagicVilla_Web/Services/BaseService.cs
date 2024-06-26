﻿using MagicVilla_Utility;
using MagicVilla_Web.Models;
using MagicVilla_Web.Services.IServices;
using Newtonsoft.Json;
using System.Text;

namespace MagicVilla_Web.Services
{
    public class BaseService : IBaseService
    {
        public APIResponse responseModel { get; set; }
        public IHttpClientFactory httpClient { get; set; }
        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new();
            this.httpClient = httpClient;
        }
        public async Task<T> SendAsync<T>(APIRequest apiReques)
        {
            try
            {
                var client = httpClient.CreateClient("MagicAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiReques.Url);
                if (apiReques.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiReques.Data),
                        Encoding.UTF8, "application/json");
                }
                switch (apiReques.ApiType)
                {
                    case SD.ApiType.POST :
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT :
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE :
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiRespone = null;

                apiRespone = await client.SendAsync(message);

                var apiContent = await apiRespone.Content.ReadAsStringAsync();
                var APIRespones = JsonConvert.DeserializeObject<T>(apiContent);
                return APIRespones;
            }
            catch (Exception ex)
            {
                var dto = new APIResponse
                {
                    ErrorMessage = new List<string> { Convert.ToString(ex.Message) },
                    IsSuccess = false
                };
                var res = JsonConvert.SerializeObject(dto);
                var APIResponse = JsonConvert.DeserializeObject<T>(res);
                return APIResponse;
            }
        }
    }
}
