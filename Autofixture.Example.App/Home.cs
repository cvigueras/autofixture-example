namespace Autofixture.Example.App
{
    public class Home
    {
        public string Access(User user)
        {
            switch (user.Age)
            {
                case < 18:
                    return "Aplicación web solo para personas mayores de edad";
                case < 30:
                    return "Consigue un descuento de 20€ en tu primer pedido";
                case < 65:
                    return "Consigue un descuento de 25€ en tu primer pedido";
                case > 65:
                    return "Consigue un descuento de 30€ en tu primer pedido";
                default:
                    return string.Empty;
            }
        }
    }
}
