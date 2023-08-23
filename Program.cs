namespace IntroAC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Ingrese el primer numero");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            int numeroDos = Convert.ToInt32(Console.ReadLine());
            int resultado = program.SumaDeDosNumeros(1, 2);
            Console.WriteLine("El resultado de 1 + 2 es " + resultado);

            Console.WriteLine("La fecha y hora actual es " + program.ObtenerFechaYHoraActual());

            Console.WriteLine("Ingresa la cadena a cortar");
            String cadenaACortar = Console.ReadLine();
            String cadenaCortada = program.ManipularCadena(cadenaACortar);
            if(cadenaCortada != "")
            {
                Console.WriteLine("Los primeros 4 caracteres son: " + cadenaCortada);
            }
        }

        //Devuelve la suma de dos numeros
        public int SumaDeDosNumeros(int a, int b)
        {
            int suma = a + b;
            
            return suma;
        }

        /*Obtengo la fecha y hora actual*/
        public DateTime ObtenerFechaYHoraActual()
        {
            return DateTime.UtcNow;
        }

        public String ManipularCadena(String cadena)
        {
            if (cadena.Length >= 4)
            {
                return cadena.Substring(0, 4);
            }
            else
            {
                Console.WriteLine("La cadena no tiene al menos 4 caracteres.");
                return string.Empty;
            }
        }

        
    }
}
