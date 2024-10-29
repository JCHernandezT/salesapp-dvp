using SalesApp;


var orderProcessor = new OrderProcessor();
var order = new Order { Id = 1, Customer = "Juan",  OrderDate = "12-12-2024", 
    OrderItems =  null, Status = OrderStatus.Pending, TotalAmount = 11}; // orden de prueba

try
{
    await orderProcessor.ProcessOrderAsync(order);
    Console.WriteLine("Pedido procesado exitosamente");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}