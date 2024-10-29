## Resumen de la Prueba

La prueba se centra en la creación de la clase `OrderProcessor`, la cual gestiona el flujo de procesamiento de pedidos mediante el método asíncrono `ProcessOrderAsync`. Este método coordina tres pasos clave:

1. **Validación del Pedido**
2. **Procesamiento del Pago**
3. **Envío de Confirmación**

### Detalles de Implementación

En la clase `OrderProcessor`, se implementan métodos asíncronos para cada uno de estos pasos:

- `ValidateOrderAsync`: Valida el pedido y simula el tiempo de procesamiento usando `Task.Delay`.
- `ProcessPaymentAsync`: Gestiona el procesamiento del pago, también utilizando `Task.Delay` para simular la duración del proceso.
- `SendConfirmationAsync`: Envía la confirmación del pedido al cliente, con simulación de tiempo mediante `Task.Delay`.

Cada uno de estos métodos puede lanzar excepciones en caso de error, lo que permite detener el flujo y manejar el fallo adecuadamente.

### Manejo de Errores

El método `ProcessOrderAsync` envuelve el flujo de procesamiento en un bloque `try-catch` centralizado. Esto permite registrar y gestionar errores de manera eficiente, asegurando la estabilidad del proceso de principio a fin.

### Simulación de Ejecución

Para ejecutar la prueba, se instancia la clase `OrderProcessor` y se llama al método `ProcessOrderAsync`. Esto permite realizar una gestión completa del pedido, desde la validación inicial hasta la confirmación final, de forma estructurada y controlada.

