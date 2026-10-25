using Dominio;

namespace Aplicacion
{
    // Fábrica encargada de centralizar la creación de objetos (Factory)
    public class TransporteFactory
    {
        public ITransporte? CrearTransporte(string? opcion)
        {
            return opcion switch
            {
                "1" => new MotoMensajeria(),
                "2" => new CamionCarga(),
                "3" => new AvionCarguero(),
                _ => null
            };
        }
    }
}
