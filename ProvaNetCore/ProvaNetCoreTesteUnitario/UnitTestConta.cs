using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProvaNetCoreTesteUnitario.Infrastructure;
using ProvaNetCoreTesteUnitario.Models;
using RestSharp;
using System.Collections.Generic;
using Xunit;

namespace ProvaNetCoreTesteUnitario
{
    public class UnitTestConta
    {
        private const string _API_ADDRESS = "http://localhost:5237";

        [Fact]
        public void CriaConta()
        {
            var objJson = new JObject(
                    new JProperty("Nome", "Conta 1"),
                    new JProperty("Descricao", "Conta descrição 1")
                );

            RestResponse response = RestClientApi.ExecutePostRequest(_API_ADDRESS, $"/Conta", objJson).Result;

            if (!string.IsNullOrEmpty(response.Content.ToString()))
            {
                var conta = JsonConvert.DeserializeObject<Conta>(response.Content.ToString());

                Assert.True(response.IsSuccessful && (response.StatusCode == System.Net.HttpStatusCode.Created) && (conta != null));
            }
            else
                Assert.True(false);
        }

        [Fact]
        public void EditaConta()
        {
            RestResponse response;

            var objJson = new JObject(
                    new JProperty("Nome", "Conta 2"),
                    new JProperty("Descricao", "Conta descrição 2")
                );

            response = RestClientApi.ExecutePostRequest(_API_ADDRESS, $"/Conta", objJson).Result;

            if (!string.IsNullOrEmpty(response.Content.ToString()))
            {
                var conta = JsonConvert.DeserializeObject<Conta>(response.Content.ToString());

                if (conta != null)
                {
                    objJson = new JObject(
                        new JProperty("Nome", "Conta 2 alterada"),
                        new JProperty("Descricao", "Conta descrição 2 alterada")
                    );

                    response = RestClientApi.ExecutePutRequest(_API_ADDRESS, $"/Conta/{conta.Id}", objJson).Result;

                    Assert.True(response.IsSuccessful && (response.StatusCode == System.Net.HttpStatusCode.NoContent));
                }
            }
            else
                Assert.True(false);
        }

        [Fact]
        public void DeletaConta()
        {
            RestResponse response;

            var objJson = new JObject(
                    new JProperty("Nome", "Conta 3"),
                    new JProperty("Descricao", "Conta descrição 3")
                );

            response = RestClientApi.ExecutePostRequest(_API_ADDRESS, $"/Conta", objJson).Result;

            if (!string.IsNullOrEmpty(response.Content.ToString()))
            {
                var conta = JsonConvert.DeserializeObject<Conta>(response.Content.ToString());

                if (conta != null)
                {
                    response = RestClientApi.ExecuteDeleteRequest(_API_ADDRESS, $"/Conta/{conta.Id}").Result;

                    Assert.True(response.IsSuccessful && (response.StatusCode == System.Net.HttpStatusCode.NoContent));
                }
            } 
            else
                Assert.True(false);
        }

        [Fact]
        public void ListarConta()
        {
            RestResponse response = RestClientApi.ExecuteGetRequest(_API_ADDRESS, $"/Conta").Result;

            if (!string.IsNullOrEmpty(response.Content.ToString()))
            {
                var listaContas = JsonConvert.DeserializeObject<List<Conta>>(response.Content.ToString());

                Assert.True(response.IsSuccessful && (response.StatusCode == System.Net.HttpStatusCode.OK) && (listaContas != null));
            } 
            else 
                Assert.True(false);
            
        }
    }
}