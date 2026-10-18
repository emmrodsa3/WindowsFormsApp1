using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Gimnasio.Common
{
    /// <summary>
    /// Representa a un cliente/socio registrado en el gimnasio.
    /// </summary>
    public class Miembro
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        // Datos de la membresía activa asignada al miembro
        public int? PlanId { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        // Constructor sin parámetros necesario para serialización a JSON/XML
        public Miembro()
        {
        }

        // Facilita mostrar la información del miembro en ComboBoxes o Listas
        public override string ToString()
        {
            return $"{Identificacion} - {Nombre}";
        }
    }
}

