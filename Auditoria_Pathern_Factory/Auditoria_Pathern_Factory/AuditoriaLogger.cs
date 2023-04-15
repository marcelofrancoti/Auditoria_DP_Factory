using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoria_Pathern_Factory
{
    public class AuditoriaLogger<T> : IAuditoriaLogger<T>
    {
        private string caminhoArquivoLog;

        public AuditoriaLogger(string caminhoArquivoLog)
        {
            this.caminhoArquivoLog = caminhoArquivoLog;
        }

        public void RegistrarEvento(T objeto)
        {
            GravarLog($"[Evento] {DateTime.Now}: {objeto.ToString()}");
        }

        public void RegistrarErro(T objeto, Exception ex)
        {
            GravarLog($"[Erro] {DateTime.Now}: {objeto.ToString()}\n{ex.ToString()}");
        }

        private void GravarLog(string mensagem)
        {
            // Lógica para gravar a mensagem de log em um arquivo de log
            using (StreamWriter writer = new StreamWriter(caminhoArquivoLog, true))
            {
                writer.WriteLine(mensagem);
            }
        }
    }
}
