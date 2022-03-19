using FormsUIActivo.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUIActivo.Domain.Entities
{
    public class Activo
    {
        /// <summary>
        /// Llave primaria de la clase activo
        /// </summary>
        public int Id { get; set; } 
        public string Name { get; set; }    
        public decimal Value { get; set; }
        public int Time { get; set; }
        public decimal ValueR { get; set; }
    }
}
