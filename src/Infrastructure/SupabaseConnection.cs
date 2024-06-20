using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Redlands.Infrastructure
{
    internal class SupabaseConnection
    {
        public async static Task<Supabase.Client> Init(IConfigurationRoot config)
        {
            try
            {
                string url = config["secret:url"] ?? throw new Exception("url can't be null");
                string key = config["secret:key"] ?? throw new Exception("key can't be null");

                var options = new Supabase.SupabaseOptions
                {
                    AutoConnectRealtime = true
                };

                var supabase = new Supabase.Client(url, key, options);
                await supabase.InitializeAsync();

                return supabase;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
