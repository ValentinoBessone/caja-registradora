const string nombreComercio = "Super Ahorro";

Console.WriteLine($"=== {nombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Hola {nombreCajero}, bienvenido a {nombreComercio}.\n");

int cantidadProductos = 0;
decimal total = 0;
string opcion = "";

do
{
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1 - Cargar un producto");
    Console.WriteLine("2 - Cerrar la venta");
    Console.Write("Opción: ");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            total += precio;
            cantidadProductos++;

            Console.WriteLine($"Producto cargado: {nombreProducto} - ${precio}\n");
            break;

        case "2":
            
            break;

        default:
            Console.WriteLine("Opción inválida. Intente de nuevo.\n");
            break;
    }

} while (opcion != "2");

const decimal DESC_10 = 0.10m;
const decimal DESC_5 = 0.05m;

decimal descuento = 0;

if (total > 50000)
    descuento = total * DESC_10;
else if (total > 20000)
    descuento = total * DESC_5;

Console.WriteLine("\n=== Cierre de Venta ===");
Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
Console.WriteLine($"Subtotal: ${total}");
Console.WriteLine($"Descuento: -${descuento}");
Console.WriteLine($"Total a pagar: ${total - descuento}\n");

Console.ReadKey();
