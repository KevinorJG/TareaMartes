using FormsUIActivo.AppCore.IContracts;
using FormsUIActivo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.AppCore.Processes
{
    public class SDA : IDepreciacion
    {
        public List<decimal> Depreciacion(Activo activo)
        {
            List<decimal> depreciaciones = new List<decimal>();
            decimal TotalVidaUtil = (activo.Time * (1 + activo.Time)) / 2;

            for (int i = 1; i < activo.Time+ 1; i++)
            {
                decimal depreciacion = (i * (activo.Value - activo.ValueR)) / TotalVidaUtil;
                depreciaciones.Add(depreciacion);
            }

            return depreciaciones;
        }
    }
}
