using FluentResults;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProvaNetCore.Data.Dtos.ConsultaCep;

namespace ProvaNetCore.Services
{
    public class ConsultaCepService
    {
        RestClientService _restClientService;

        public ConsultaCepService(RestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public ConsultaCepResponseDto ConsultaCep(string Cep)
        {
            string response = _restClientService.ExecuteGetRequest("http://viacep.com.br/ws", $"/{Cep}/json").Result.ToString();

            if(!string.IsNullOrEmpty(response))
            {
                var jsonObject = JObject.Parse(response);

                ConsultaCepResponseDto consultaCepResponseDto = new ConsultaCepResponseDto {
                    CepCode = jsonObject.GetValue("cep").ToString(),
                    Logradouro = jsonObject.GetValue("logradouro").ToString(),
                    Complemento = jsonObject.GetValue("complemento").ToString(),
                    Bairro = jsonObject.GetValue("bairro").ToString(),
                    Localidade = jsonObject.GetValue("localidade").ToString(),
                    Uf = jsonObject.GetValue("uf").ToString(),
                    Ibge = jsonObject.GetValue("ibge").ToString(),
                    Gia = jsonObject.GetValue("gia").ToString(),
                    Ddd = jsonObject.GetValue("ddd").ToString(),
                    Siafi = jsonObject.GetValue("siafi").ToString()
                };

                return consultaCepResponseDto;
            }

            return null;
        } 
    }
}
