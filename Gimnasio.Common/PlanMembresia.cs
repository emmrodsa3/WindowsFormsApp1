using System;
using System.Collections.Generic;
using System.Text;

namespace Gimnasio.Common
{
    /// <summary>
    /// Representa los planes ofrecidos por el gimnasio (Ej: Mensual, Trimestral, Anual).
    /// </summary>
    public class PlanMembresia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int DuracionDias { get; set; } // Días de validez del plan (ej: 30, 90, 365)

        public PlanMembresia() { }

        public override string ToString()
        {
            return $"{Nombre} ({DuracionDias} días) - ₡{Precio:N2}";
        }
    }
}
