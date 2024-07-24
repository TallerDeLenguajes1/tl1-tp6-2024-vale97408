// See https://aka.ms/new-console-template for more information

// PRUEBA DE USO DE C# 
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a:"+a );
Console.WriteLine("Valor de b: "+b);


// ==================EJERCICIO 1=========================

 Console.WriteLine("-----Ingrese un número entero mayor que 0 para invertir:------");


        string cadena = Console.ReadLine(); // Espera que el usuario ingrese una cadena de numeros y la guarda en el string cadena 
         int inverso = 0;

        if (int.TryParse(cadena, out int nro) && nro > 0) // Tranformo el caracter ingresado en numero y analizo si es mayor que 0 
        {
            while (nro > 0) // Analizo digito por digito 
            {
              int digito= nro%10;
              inverso= inverso*10 + digito;
              nro= nro/10;

            }

            Console.WriteLine($"El numero inverso es:  {inverso}"); // Muestra una variable agregando el $
       

           //Si usara una funcion:
           // int numeroInvertido= numeroInvertido(nro);
           // Console.WriteLine($"El número invertido es: {reversedNumber}");
        }

        else
        {
            Console.WriteLine("USTED no ingreso un numero. Por favor, ingrese un número entero mayor que 0.");
        }

    

//static int numeroInvertido(int number)
   // {
      //  int reversed = 0;
        
      //   while (number > 0)
       // {
         //   int digit = number % 10;
           // reversed = reversed * 10 + digit;
            //number /= 10;
        //}

        //return reversed;
         //}



// ==================EJERCICIO 2=========================
 Console.WriteLine("========///////Creando el branch///////=======");
 
int volver = 0;
        do
        {
            Console.WriteLine("========CALCULADORA 1=======");

            Console.WriteLine("---OPCIONES: ");
            Console.WriteLine("-----Ingrese el número de la operación que desea realizar: ");
            Console.WriteLine("1-SUMAR");
            Console.WriteLine("2-RESTAR");
            Console.WriteLine("3-DIVIDIR");
            Console.WriteLine("4-MULTIPLICAR");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.WriteLine("Ingrese 2 números para realizar la operación deseada");

            Console.WriteLine("Primer número: ");
            int num1;
            if (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Número inválido.");
                continue;
            }

            Console.WriteLine("Segundo número: ");
            int num2;
            if (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Número inválido.");
                continue;
            }

            double resultado = 0; 
            bool esOperacionValida = true;

            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 - num2;
                    break;

                case 3:
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                        esOperacionValida = false;
                    }
                    break;

                case 4:
                    resultado = num1 * num2;
                    break;

                default:
                    Console.WriteLine("Opción ingresada inválida");
                    esOperacionValida = false;
                    break;
            }

            if (esOperacionValida)
            {
                Console.WriteLine($"El resultado de la operación es: {resultado}");
            }

            Console.WriteLine("Desea realizar otro cálculo? (1 para sí, cualquier otra tecla para no)");
            if (!int.TryParse(Console.ReadLine(), out volver) || volver != 1)
            {
                volver = 0;
            }

        } while (volver == 1);
    


