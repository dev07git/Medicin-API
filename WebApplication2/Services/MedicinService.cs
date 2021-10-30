using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class MedicinService: IMedicinService
    {
        public async Task<List<Medicin>> GetMedicinsAsync()
        {
            List<Medicin> medicins = await ReadFromJson();
           

            foreach (var item in medicins)
            {
                if (item.ExpiryDate <= DateTime.Now.AddDays(30))
                {
                    item.BgColor = "red";
                }

                if (item.Qty < 20)
                {
                    item.BgColor = "yellow";
                }
            }

            return await Task.Run(()=> medicins);
        }

        public async Task<List<Medicin>> ReadFromJson()
        {
          
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Medicin.json"}");
            var jsonText = System.IO.File.ReadAllText(filepath);
            var format = "dd/MM/yyyy"; // your datetime format
            var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
            var medicins = JsonConvert.DeserializeObject<List<Medicin>>(jsonText, dateTimeConverter);

            return medicins;
        }


        }
}
