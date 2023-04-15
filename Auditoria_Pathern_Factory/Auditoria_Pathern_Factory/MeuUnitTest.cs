using Auditoria_Pathern_Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

[TestClass]
public class MeuUnitTest
{
    [TestMethod]
    public void TesteAuditoriaLogger()
    {
        string caminhoDoDiretorio = @"C:\Users\redbu\OneDrive\Documentos\Projetos Pessoais\Auditoria_Pathern_Factory\";
        DirectoryInfo diretorio = new DirectoryInfo(caminhoDoDiretorio);
        DirectorySecurity security = diretorio.GetAccessControl();
      
        diretorio.SetAccessControl(security);

        // Criar o logger de auditoria com o caminho do arquivo de log
        IAuditoriaLogger<string> auditoriaLogger = AuditoriaLoggerFactory.CriarAuditoriaLogger<string>(caminhoDoDiretorio + "log.txt");

        // Registrar um evento
        auditoriaLogger.RegistrarEvento("Evento de teste");

        // Registrar um erro
        auditoriaLogger.RegistrarErro("Erro de teste", new Exception("Exceção de teste"));


    }
}