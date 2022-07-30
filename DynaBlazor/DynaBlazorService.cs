using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaBlazor
{
    public class DynaBlazorService
    {
        public static void Register()
        {
            var assembly = typeof(DynaBlazorService).Assembly;
            var filePaths = assembly.GetManifestResourceNames().Where(rnn => rnn.Contains("wwwroot"));

            foreach (var path in filePaths)
            {
                
            }
        }
    }
}
