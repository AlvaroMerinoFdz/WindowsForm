using System;

namespace ValidacionDatos.Errores
{
    class ErrorNIFException : ApplicationException
    {
        public ErrorNIFException()
        {
        }

        public string Message => "La letra no es correcta";
    }
}
