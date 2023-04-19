
int dato1 = 16;
String dato2 = "25g";
int resultado = dato1 + Convert. ToInt32( dato2);

int dato1 = 16;
String dato2 = "25g";

try {
    int resultado = dato1 + Convert.ToInt32(dato2);
    Console.WriteLine("El resultado es: " + resultado);
} catch (FormatException e) {
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}
