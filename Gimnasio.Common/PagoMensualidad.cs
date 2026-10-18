using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Gimnasio.Common
{
    /// <summary>
    /// Registro de las transacciones de pago realizadas por los miembros.
    /// </summary>
    public class PagoMensualidad
    {
        public int Id { get; set; }
        public int MiembroId { get; set; }
        public int PlanId { get; set; }
        public DateTime FechaPago { get; set; } = DateTime.Now;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal MontoPagado { get; set; }

        public PagoMensualidad() { }
    }
}
