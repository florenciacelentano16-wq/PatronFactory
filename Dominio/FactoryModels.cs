using System;

namespace Dominio
{
    // 1. Producto (Interfaz común)
    public interface ITransporte
    {
        void EntregarPedido(string destino);
    }

    // 2. Productos Concretos
    public class MotoMensajeria : ITransporte
    {
        public void EntregarPedido(string destino) =>
            Console.WriteLine($"[Moto]: Entrega rápida de paquete pequeño hacia {destino}.");
    }

    public class CamionCarga : ITransporte
    {
        public void EntregarPedido(string destino) =>
            Console.WriteLine($"[Camión]: Entrega terrestre pesada por ruta hacia {destino}.");
    }

    public class AvionCarguero : ITransporte
    {
        public void EntregarPedido(string destino) =>
            Console.WriteLine($"[Avión]: Envío aéreo internacional express hacia {destino}.");
    }
}
