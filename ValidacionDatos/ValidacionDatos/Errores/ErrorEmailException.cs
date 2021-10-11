using System;

namespace ValidacionDatos.Errores
{
    class ErrorEmailException : ApplicationException
    {
        public ErrorEmailException()
        {
        }
        public string Message => "El email introducido no es correcto";
    }
}
