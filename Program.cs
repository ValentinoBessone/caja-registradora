const string nombreComercio = "Super Ahorro";

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();
Console.WriteLine($"Hola {nombreCajero}, bienvenido a {nombreComercio}.");
Console.ReadKey();

Console.Write("Ingrese el nombre del producto: ");
string nombreProducto = Console.ReadLine();
Console.Write("Ingrese el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine();
Console.WriteLine($"Producto: {nombreProducto} - Precio: ${precio}");