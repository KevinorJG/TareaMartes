using FormsUIActivo.AppCore.IContracts;
using FormsUIActivo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.AppCore.Processes
{
    public class LineaRecta : IDepreciacion
    {
        public List<decimal> Depreciacion(Activo activo)
        {
            decimal depreciacion = (activo.Value - activo.ValueR) / activo.Time;
            return Enumerable.Repeat<decimal>(depreciacion, activo.Time).ToList();
        }
    }
}
