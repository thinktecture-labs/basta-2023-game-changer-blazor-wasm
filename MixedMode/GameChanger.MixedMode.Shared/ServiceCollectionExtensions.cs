using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.MixedMode.Shared
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMixedModeServices(this IServiceCollection services, string key)
        {
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            services.AddScoped(sp => {
                var client = new HttpClient();
                client.BaseAddress = new("https://api.themoviedb.org/3/");
                client.DefaultRequestHeaders.Authorization = new("Bearer", key);
                return client;
            });
        }
    }
}
