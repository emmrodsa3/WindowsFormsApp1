using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Gimnasio.Common.Exceptions
{
    /// <summary>
    /// Excepción personalizada para capturar errores de reglas de negocio en el Gimnasio.
    /// </summary>
    public class BusinessException : Exception
    {
        public string ErrorCode { get; }

        public BusinessException(string message, string errorCode = "BIZ_ERROR")
            : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
