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
    





 while (true)
        {
            Console.WriteLine("========CALCULADORA 2=======");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Operaciones básicas");
            Console.WriteLine("2. Valor absoluto");
            Console.WriteLine("3. Cuadrado");
            Console.WriteLine("4. Raíz cuadrada");
            Console.WriteLine("5. Seno");
            Console.WriteLine("6. Coseno");
            Console.WriteLine("7. Parte entera de un float");
            Console.WriteLine("8. Máximo entre dos números");
            Console.WriteLine("9. Mínimo entre dos números");
            Console.WriteLine("10. Salir");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            if (opcion == 10)
            {
                break;
            }

            double num1 = 0, num2 = 0;

            if (opcion >= 2 && opcion <= 9)
            {
                Console.WriteLine("Ingrese un número:");
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Número inválido.");
                    continue;
                }
            }

            if (opcion >= 8 && opcion <= 9)
            {
                Console.WriteLine("Ingrese otro número:");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Número inválido.");
                    continue;
                }
            }

            switch (opcion)
            {
                case 1:
                    OperacionesBasicas();
                    break;
                case 2:
                    Console.WriteLine($"El valor absoluto es: {Math.Abs(num1)}");
                    break;
                case 3:
                    Console.WriteLine($"El cuadrado es: {Math.Pow(num1, 2)}");
                    break;
                case 4:
                    if (num1 < 0)
                    {
                        Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
                    }
                    else
                    {
                        Console.WriteLine($"La raíz cuadrada es: {Math.Sqrt(num1)}");
                    }
                    break;
                case 5:
                    Console.WriteLine($"El seno es: {Math.Sin(num1)}");
                    break;
                case 6:
                    Console.WriteLine($"El coseno es: {Math.Cos(num1)}");
                    break;
                case 7:
                    Console.WriteLine($"La parte entera es: {Math.Truncate(num1)}");
                    break;
                case 8:
                    Console.WriteLine($"El máximo entre {num1} y {num2} es: {Math.Max(num1, num2)}");
                    break;
                case 9:
                    Console.WriteLine($"El mínimo entre {num1} y {num2} es: {Math.Min(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción ingresada inválida");
                    break;
            }
        }
    

    static void OperacionesBasicas()
    {
        Console.WriteLine("Ingrese 2 números para realizar la operación deseada");

        Console.WriteLine("Primer número: ");
        int num1;
        if (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.WriteLine("Segundo número: ");
        int num2;
        if (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Número inválido.");
            return;
        }

        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Dividir");
        Console.WriteLine("4. Multiplicar");

        int opcion;
        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Opción inválida.");
            return;
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
    }



// ==================EJERCICIO 4=========================

