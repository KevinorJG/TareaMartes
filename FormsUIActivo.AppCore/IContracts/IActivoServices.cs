using FormsUIActivo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.AppCore.IContracts
{
    public interface IActivoServices
    {
        IReadOnlyList<Activo> activos(Activo activo);
    }
}
