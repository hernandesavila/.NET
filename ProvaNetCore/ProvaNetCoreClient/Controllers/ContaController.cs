using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProvaNetCoreClient.Models;
using ProvaNetCoreClient.Models.Infraestructure;
using Microsoft.Extensions.Configuration;

namespace ProvaNetCoreClient.Controllers
{
    public class ContaController : Controller
    {
        public ActionResult Index()
        {
            string response = RestClientApi.ExecuteGetRequest(GetConfiguration("ApiBaseAddress"), $"/Conta").Result.ToString();

            if (!string.IsNullOrEmpty(response))
            {
                var listaContas = JsonConvert.DeserializeObject<List<Conta>>(response);

                return View(listaContas);
            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var objJson = new JObject(
                    new JProperty("Nome", collection.FirstOrDefault(c => c.Key == "Nome").Value.ToString()),
                    new JProperty("Descricao", collection.FirstOrDefault(c => c.Key == "Descricao").Value.ToString())
                );

                string response = RestClientApi.ExecutePostRequest(GetConfiguration("ApiBaseAddress"), $"/Conta", objJson).Result.ToString();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContaController/Edit/5
        public ActionResult Edit(int id)
        {
            string response = RestClientApi.ExecuteGetRequest(GetConfiguration("ApiBaseAddress"), $"/Conta/{id}").Result.ToString();

            if (!string.IsNullOrEmpty(response))
            {
                var conta = JsonConvert.DeserializeObject<Conta>(response);

                return View(conta);
            }

            return View();
        }

        // POST: ContaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var objJson = new JObject(
                    new JProperty("Nome", collection.FirstOrDefault(c => c.Key == "Nome").Value.ToString()),
                    new JProperty("Descricao", collection.FirstOrDefault(c => c.Key == "Descricao").Value.ToString())
                );

                string response = RestClientApi.ExecutePutRequest(GetConfiguration("ApiBaseAddress"), $"/Conta/{id}", objJson).Result.ToString();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContaController/Delete/5
        public ActionResult Delete(int id)
        {
            string response = RestClientApi.ExecuteGetRequest(GetConfiguration("ApiBaseAddress"), $"/Conta/{id}").Result.ToString();

            if (!string.IsNullOrEmpty(response))
            {
                var conta = JsonConvert.DeserializeObject<Conta>(response);

                return View(conta);
            }

            return View();
        }

        // POST: ContaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                string response = RestClientApi.ExecuteDeleteRequest(GetConfiguration("ApiBaseAddress"), $"/Conta/{id}").Result.ToString();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private string GetConfiguration(string parameter)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            return config.GetSection(parameter).Value;
        }
    }
}
