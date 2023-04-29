using System.Data;

try
{
    int op1;
    Console.WriteLine("\t\t\t\t\tBienvenido a BATALLA DE BARCOS");
    Console.WriteLine("\n0. JUGAR\n1. Objetivo del juego\n2.Cómo jugar\n3. Salir");
    op1 = Convert.ToInt32(Console.ReadLine());

        switch (op1)
        {
            case 0:
                int op2;
                Console.WriteLine("Selecciona la dificultad:");
                Console.WriteLine("\n0. Fácil\nTablero 3x3 con intentos ilimitados." +
                    "\n\n1. Normal\nTablero 5x5 con intentos ilimitados." +
                    "\n\n2. Difícil\nTablero 7x7 con 15 intentos.");
                op2 = Convert.ToInt32(Console.ReadLine());
                switch (op2)
                {
                    case 0:
                        for (int f = 0; f < tablero.Length; f++)
                        {
                            
                        }
                    break;
                    
                    default:
                    break;
                }
                break;

            case 1:
                Console.WriteLine("En cada turno debes intentar destruir mi flota en un tablero cuadrado, yo" +
                    "colocaré cierta cantidad de barcos dependiendo de la dificultad seleccionada. Ganarás cuando" +
                    "los destruyas todos y dependiendo de tus aciertos y fallos tendrás cierta cantidad de puntos. " +
                    "\n¡Trata de tener la mayor puntuación posible!");
            break;
            
            case 2:
                Console.WriteLine("Al momento de iniciar comenzará la fase de ataque, se presenta un tablero que" +
                    "representa el mar, sin embargo, los barcos están ocultos. Escribe las coordenadas de la casilla" +
                    "que deseas atacar, indica la fila seguida de la columna. \nLos aciertos revelarán la posición " +
                    "del barco y dependiendo del tamaño se sumarán puntos. Los barcos más pequeños y por ende más" +
                    "difíciles de encontrar serán tu mejor apuesta para conseguir una puntuación alta. Estos se" +
                    "marcarán con una O. \n¡SI ACIERTAS EN COMBO SE SUMARÁN AÚN MÁS PUNTOS!");
            break;

            default:
            break;
        }

        int[,] tablero = new int[];
    } while (op1 != 3);

    Console.WriteLine("Vuelve cuando quieras hundir un par de barcos.\n>:)");
}
catch(Exception ex)
{
    Console.WriteLine("\nUps, prueba con otro número.");
    Console.Write("La excepción es: " + ex.Message);
}