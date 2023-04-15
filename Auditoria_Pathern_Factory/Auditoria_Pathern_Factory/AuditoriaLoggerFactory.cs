using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoria_Pathern_Factory
{
    public class AuditoriaLoggerFactory
    {
        public static IAuditoriaLogger<T> CriarAuditoriaLogger<T>(string caminhoArquivoLog)
        {
            return new AuditoriaLogger<T>(caminhoArquivoLog);
        }
    }
}
