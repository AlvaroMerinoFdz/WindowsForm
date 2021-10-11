using System;

namespace ValidacionDatos.Errores
{
    class ErrorCuentaException : ApplicationException
    {
        public ErrorCuentaException()
        {
        }

        public string Message => "El número de cuenta no es correcto.";
    }

}
