using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auditoria_Pathern_Factory
{
    public interface IAuditoriaLogger<T>
    {
        void RegistrarEvento(T objeto);
        void RegistrarErro(T objeto, Exception ex);
    }
}
