
int datoa = 16;
String datob = "25g";
int resultado = datol + Convert. ToInt32( dato2);

int datoa = 16;
String datob = "25g";

try {
    int resultado = datoa + Convert.ToInt32(datob);
    Console.WriteLine("El resultado es: " + resultado);
} catch (FormatException e) {
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}
