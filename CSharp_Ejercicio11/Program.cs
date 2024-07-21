//Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana , teniendo en cuenta que el 1 es Lunes, hacer con un switch.
Console.WriteLine("Ingrese un número del 1 al 7:");
int numero123 = Convert.ToInt32(Console.ReadLine());
if (numero123 % 2 == 0)
{
    switch (numero123)
    {
        case 2:
            Console.WriteLine("Martes");
            break;
        case 4:
            Console.WriteLine("Jueves");
            break;
        case 6:
            Console.WriteLine("Sábado");
            break;
    }
}
else
{
    switch (numero123)
    {
        case 1:
            Console.WriteLine("Lunes");
            break;
        case 3:
            Console.WriteLine("Miércoles");
            break;
        case 5:
            Console.WriteLine("Viernes");
            break;
        case 7:
            Console.WriteLine("Domingo");
            break;
    }
}