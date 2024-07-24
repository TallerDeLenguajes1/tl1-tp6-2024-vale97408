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
/*
 // Ejercicio 1: Obtener la longitud de la cadena y mostrar por pantalla.
        Console.WriteLine("Ingrese una cadena de texto:");
        string cadena = Console.ReadLine();
        int longitud = cadena.Length;
        Console.WriteLine($"La longitud de la cadena es: {longitud}");

        // Ejercicio 2: Concatenar dos cadenas.
        Console.WriteLine("Ingrese una segunda cadena de texto:");
        string segundaCadena = Console.ReadLine();
        string cadenaConcatenada = cadena + segundaCadena;
        Console.WriteLine($"La cadena concatenada es: {cadenaConcatenada}");

        // Ejercicio 3: Extraer una subcadena.
        Console.WriteLine("Ingrese el índice inicial para la subcadena:");
        int startIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la longitud de la subcadena:");
        int length = int.Parse(Console.ReadLine());
        string subcadena = cadena.Substring(startIndex, length);
        Console.WriteLine($"La subcadena es: {subcadena}");

        // Ejercicio 4: Utilizar la calculadora creada anteriormente.
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese la operación a realizar (1-Sumar, 2-Restar, 3-Dividir, 4-Multiplicar):");
        int opcion = int.Parse(Console.ReadLine());
        int resultado = 0;
        
        switch(opcion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 / num2;
                break;
            case 4:
                resultado = num1 * num2;
                break;
            default:
                Console.WriteLine("Opción ingresada inválida");
                return;
        }
        Console.WriteLine($"La operación es: {num1} {GetOperationSymbol(opcion)} {num2} = {resultado}");

        // Ejercicio 5: Recorrer la cadena con un ciclo foreach.
        Console.WriteLine("Recorriendo la cadena con un ciclo foreach:");
        foreach (char c in cadena)
        {
            Console.WriteLine(c);
        }

        // Ejercicio 6: Buscar la ocurrencia de una palabra en la cadena.
        Console.WriteLine("Ingrese la palabra a buscar en la cadena:");
        string palabra = Console.ReadLine();
        bool contienePalabra = cadena.Contains(palabra);
        Console.WriteLine(contienePalabra ? "La palabra está en la cadena." : "La palabra no está en la cadena.");

        // Ejercicio 7: Convertir la cadena a mayúsculas y luego a minúsculas.
        string cadenaMayusculas = cadena.ToUpper();
        string cadenaMinusculas = cadena.ToLower();
        Console.WriteLine($"Cadena en mayúsculas: {cadenaMayusculas}");
        Console.WriteLine($"Cadena en minúsculas: {cadenaMinusculas}");

        // Ejercicio 8: Ingresar una cadena separada por caracteres y mostrar los resultados.
        Console.WriteLine("Ingrese una cadena separada por comas:");
        string cadenaSeparada = Console.ReadLine();
        string[] partes = cadenaSeparada.Split(',');
        Console.WriteLine("Las partes de la cadena son:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte.Trim());
        }

        // Ejercicio 9: Resolver una ecuación simple como cadena de caracteres.
        Console.WriteLine("Ingrese una ecuación simple (por ejemplo, 582+2):");
        string ecuacion = Console.ReadLine();
        string[] partesEcuacion = ecuacion.Split(new char[] { '+', '-', '*', '/' });
        int numA = int.Parse(partesEcuacion[0]);
        int numB = int.Parse(partesEcuacion[1]);
        char operador = ecuacion[partesEcuacion[0].Length];
        int resultadoOperacion = 0;

        switch (operador)
        {
            case '+':
                resultadoOperacion = numA + numB;
                break;
            case '-':
                resultadoOperacion = numA - numB;
                break;
            case '*':
                resultadoOperacion = numA * numB;
                break;
            case '/':
                resultadoOperacion = numA / numB;
                break;
            default:
                Console.WriteLine("Operador inválido.");
                return;
        }
        Console.WriteLine($"La operación {numA} {operador} {numB} = {resultadoOperacion}");
    

    static string GetOperationSymbol(int opcion)
    {
        return opcion switch
        {
            1 => "+",
            2 => "-",
            3 => "/",
            4 => "*",
            _ => "?"
        };
    }
*/

Console.WriteLine("Ingrese una cadena");
string cadenaUsu = Console.ReadLine();
int longitudCadena = cadenaUsu.Length;
Console.WriteLine($"La longitud de la cadena ingresada por el usuario es {longitudCadena}");
Console.WriteLine("Ingrese una segunda cadena");
string cadenaUsu2 = Console.ReadLine();
string concatenacion = cadenaUsu + cadenaUsu2;
Console.WriteLine($"La concatenacion de las cadenas ingresadas es: {concatenacion}");

Console.WriteLine("Extraemos una subcadena de la primera cadena ingresada\n");
string ini;
string longit;
int inicio;
int final;
do
{
    Console.WriteLine("Ingrese a partir de que posicion de la cadena principal quiere extraer la subcadena\n");
    ini = Console.ReadLine();
    Console.WriteLine("Ingrese la longitud que debe tener la subcadena\n");
    longit = Console.ReadLine();
} while (!int.TryParse(ini, out inicio) || !int.TryParse(longit, out final));
string subcadena = cadenaUsu.Substring(inicio-1, final);
Console.WriteLine($"La subcadena generada es \"{subcadena}\"\n");


Console.WriteLine("Hacemos la suma de numeros ingresados por el usuario y mostramos el resultado en un cadena de texto\n");

int controla; 
do
{
    Console.WriteLine("\n--------Calculadora--------\n");
    Console.WriteLine("\n1.SUMA");
    Console.WriteLine("\n2.RESTA");
    Console.WriteLine("\n3.MULTIPLICACION");
    Console.WriteLine("\n4.DIVISION");
    Console.WriteLine("\nElija la operacion que desea realizar: ");
    string operacion = Console.ReadLine(); 
    int op;
    string n1, n2;
    float num1, num2;
    if(int.TryParse(operacion, out op))
    {
      do
      {
         Console.WriteLine("\nIngrese el primer numero: ");
         n1 = Console.ReadLine(); 
         Console.WriteLine("\nIngrese el segundo numero: ");
         n2 = Console.ReadLine();
      } while (!(float.TryParse(n1, out num1) && float.TryParse(n2, out num2)));
      switch (op)
      {
         case 1:
               float suma = num1 + num2; 
               Console.WriteLine("\nLa suma de "+num1+ " y de "+num2+" es "+suma);
               break;
         case 2:
               float resta = num1 - num2;
               Console.WriteLine("\nLa diferencia de "+num1+ " y de "+num2+" es "+resta);
               break;
         case 3:
               float producto = num1*num2;
               Console.WriteLine("\nEl producto de "+num1+ " y de "+num2+" es "+producto);
               break;
         case 4:
               if(num2 != 0)
               {
                  float cociente = num1/num2;
                  Console.WriteLine("\nEl cociente entre "+num1+ " y "+num2+" es "+cociente);
               }else{
                  Console.WriteLine("\nNo se puede dividir en 0");
               }
               break;
      }
   }
   Console.WriteLine("\nIngrese 1 si desea continuar operando. Caso contrario ingrese 0");
    string control = Console.ReadLine();
    if(!int.TryParse(control, out controla))
    {
      controla = 1;
    }
}while (controla != 0);

Console.WriteLine("Recorremos la primera cadena con un foreach caracter por caracter e imprimimos cada uno: \n");
foreach (char caracter in cadenaUsu)
{
   Console.WriteLine(caracter);
}

Console.WriteLine("Buscar una palabra en una cadena");
Console.WriteLine("\nIngrese la palabra que desea buscar en la cadena: ");
string PalabraAbuscar = Console.ReadLine();
if (cadenaUsu.IndexOf(PalabraAbuscar, 0, cadenaUsu.Length) != -1)
{
   int start = 0;
   int pos = 0;
   int end = cadenaUsu.Length;
   int c = 0;
   Console.WriteLine("La palabra ingresada aparece en la cadena en la/s posicion/es:");
   while ((start <= end) && (pos > -1))
   {
      c = end - start;
      pos = cadenaUsu.IndexOf(PalabraAbuscar, start, c);
      if (pos == -1) break;
      Console.WriteLine(pos+1);
      start = pos+1;
   }
}else
{
   Console.WriteLine("La palabra ingresada no aparece en la cadena\n");
}

Console.WriteLine($"\nLa cadena en mayusculas es \"{cadenaUsu.ToUpper()}\"");
Console.WriteLine($"\nLa cadena en minusculas es \"{cadenaUsu.ToLower()}\"");

Console.WriteLine("Separador de cadenas");

Console.WriteLine("\nIngrese la cadena que va a separar");
string cadenaAseparar = Console.ReadLine();
string separador;
do
{
   Console.WriteLine("\nIngrese el separador de la cadena");
   separador = Console.ReadLine();
   if(!cadenaAseparar.Contains(separador))
   {
      Console.WriteLine("Separador no válido. No se encuentra en la cadena. Ingrese uno nuevamente");
   }
}while(!cadenaAseparar.Contains(separador));

string [] palabrasSeparadas = cadenaAseparar.Split(separador);

Console.WriteLine("\nLas cadenas generadas son:");
foreach(string cadenas in palabrasSeparadas)
{
   Console.WriteLine(cadenas);
}

Console.WriteLine("A partir de una cadena de texto se resuelve una operacion simple");

Console.WriteLine("\nIngrese la expresion a resolver\n");
string expresion = Console.ReadLine();
string [] operandos;
float operando1;
float operando2;
float respuesta = 0;
int error = 0;
if (expresion.Contains('+'))
{
   operandos = expresion.Split('+');
   if(float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1 + operando2;
   }else
   {
      error = 1; 
   }
} else if (expresion.Contains('-'))
{
   operandos = expresion.Split('-');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1 - operando2;
   } else
   {
      error = 1; 
   }
} else if (expresion.Contains('*'))
{
   operandos = expresion.Split('*');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      respuesta = operando1*operando2;
   }else
   {
      error = 1; 
   }
}else if (expresion.Contains('/'))
{
   operandos = expresion.Split('/');
   if (float.TryParse(operandos[0].Trim(), out operando1) && float.TryParse(operandos[1].Trim(), out operando2))
   {
      if(operando2 != 0)
      {
         respuesta = operando1/operando2;
      }else
      {
         Console.WriteLine("\nNo se puede dividir en 0");
      }
   } else
   {
      error = 1;  
   }
}else
{
   Console.WriteLine("\nNo se ha ingresado ningun operador valido");
}
if (error == 1)
{
   Console.WriteLine($"Operando no válidos\n");
}else
{
   Console.WriteLine($"El resultado de la expresion es {respuesta}");
}
