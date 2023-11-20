namespace Escuela.BusinessRules.PersonalExcepcion
{
    public class DBMySqlException : Exception
    {


        public int Numero { get; private set; }
        public string ErrorMensaje { get; private set; }
        public DBMySqlException(int numero, string mensaje)
        {
            switch (numero)
            {
                case 1045:
                    Numero = 401;
                    ErrorMensaje = "Usuario o contraseña inválido.";
                    break;
                case 1042:
                    Numero = 503;
                    ErrorMensaje = "El servidor no es accesible.";
                    break;
                case 1049:
                    Numero = 404;
                    ErrorMensaje = "La base de datos no existe.";
                    break;
                default:
                    Numero = numero;
                    ErrorMensaje = mensaje;
                    break;
            }
        }
    }
}
