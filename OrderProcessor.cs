using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp
{
    internal class OrderProcessor
    {
        // ... (Propiedades para representar un pedido, como ID, productos, etc.)
        public async Task ProcessOrderAsync(Order order)
        {
            try
            {
                await ValidateOrderAsync(order);
                await ProcessPaymentAsync(order);
                await SendConfirmationAsync(order);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (log, notificación, etc.)
                Console.WriteLine($"Error al procesar el pedido: {ex.Message}");
            }
        }

        public async Task ValidateOrderAsync(Order order)
        {
            // Lógica de validación (inventario, descuentos, etc.)
            await Task.Delay(2000); // Simula un retraso de 2 segundos
            if (order.TotalAmount < 10 || order.Customer == null)
            {
                throw new InvalidOperationException("Pedido inválido");
            }
            Console.WriteLine("Orden validada exitosamente.");
        }
        public async Task ProcessPaymentAsync(Order order)
        {
            // Lógica de procesamiento de pago (integración con pasarela de pago)
            await Task.Delay(1000); // Simula un retraso de 1 segundo
            if (order.TotalAmount < 10 || order.Customer == null)
            {
                throw new Exception("Pago no autorizado");
            }
            Console.WriteLine("Pago procesado exitosamente.");
        }

        public async Task SendConfirmationAsync(Order order)
        {
            // Lógica para enviar la confirmación (email, SMS, etc.)
            await Task.Delay(500); // Simula un retraso de 500 ms
            Console.WriteLine($"Confirmación de pedido enviada para el pedido {order.Id}");
            Console.WriteLine("Confirmacion enviada exitosamente.");
        }

    }
}
