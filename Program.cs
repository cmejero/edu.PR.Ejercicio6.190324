namespace edu.PR.Ejercicio6._1903
{
    internal class Program
    {
        static string rutaTextoUno = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\CSI1\\Programación\\ActividadesTRYCATCH\\TextoUno.txt";
        static string rutaTextoDos = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\CSI1\\Programación\\ActividadesTRYCATCH\\TextoDos.txt";
        static string rutaTextoTres = "C:\\Users\\Carlo\\OneDrive\\Escritorio\\CSI1\\Programación\\ActividadesTRYCATCH\\TextoTres.txt";


        static void Main(string[] args)
        {
            
            
            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = menuYSeleccion();

                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Has seleccionado cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Has seleccionado texto uno");
                        textoUno();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado texto dos");
                        textoDos();
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado texto tres");
                        textoTres();
                        break;
                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con ninguna");
                        break;
                }

            } while (!cerrarMenu);


            

        }

        static private int menuYSeleccion()
        {
            int opcionSeleccionada;
            Console.WriteLine("Elija una opción para modificar");
            Console.WriteLine("################################");
            Console.WriteLine("0.Cerrar Menu");
            Console.WriteLine("1.texto uno");
            Console.WriteLine("2.texto dos");
            Console.WriteLine("3.texto tres");
            Console.WriteLine("################################");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            return opcionSeleccionada;

        }


        static private void textoUno()
        {
            using (StreamReader sr = new StreamReader(rutaTextoUno))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");



                Console.WriteLine("Introduzca el texto que deseas");
                string textoUsuario = Console.ReadLine();
                Console.WriteLine("Introduzca la línea que deseas introducir el texto");
                int numLinea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduzca la posicion");
                int posicion = Convert.ToInt32(Console.ReadLine());

                try
                {
                    string[] filas = File.ReadAllLines(rutaTextoUno);

                    if (numLinea >= 1 && numLinea <= filas.Length)
                    {
                        string linea = filas[numLinea - 1];

                        if (posicion >= 0 && posicion <= linea.Length)
                        {
                            string nuevaLinea = linea.Insert(posicion, textoUsuario);

                            filas[numLinea - 1] = nuevaLinea;

                            File.WriteAllLines(rutaTextoUno, filas);

                            Console.WriteLine("El texto ha sido introducido correctamente");
                        }
                        else
                        {
                            Console.WriteLine("la posicion indicada no corresponde con el texto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("la línea indicada no corresponde con el texto");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
                }

            }


            
        }
        static private void textoDos()
        {
            using (StreamReader sr = new StreamReader(rutaTextoDos))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");



                Console.WriteLine("Introduzca el texto que deseas");
                string textoUsuario = Console.ReadLine();
                Console.WriteLine("Introduzca la línea que deseas introducir el texto");
                int numLinea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduzca la posicion");
                int posicion = Convert.ToInt32(Console.ReadLine());

                try
                {
                    string[] filas = File.ReadAllLines(rutaTextoDos);

                    if (numLinea >= 1 && numLinea <= filas.Length)
                    {
                        string linea = filas[numLinea - 1];

                        if (posicion >= 0 && posicion <= linea.Length)
                        {
                            string nuevaLinea = linea.Insert(posicion, textoUsuario);

                            filas[numLinea - 1] = nuevaLinea;

                            File.WriteAllLines(rutaTextoDos, filas);

                            Console.WriteLine("El texto ha sido introducido correctamente");
                        }
                        else
                        {
                            Console.WriteLine("la posicion indicada no corresponde con el texto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("la línea indicada no corresponde con el texto");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
                }

            }



        }
        static private void textoTres()
        {
            using (StreamReader sr = new StreamReader(rutaTextoTres))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Contenido del archivo:\n" + contenido);

                Console.WriteLine("-----------------------------------------------------------------------");



                Console.WriteLine("Introduzca el texto que deseas");
                string textoUsuario = Console.ReadLine();
                Console.WriteLine("Introduzca la línea que deseas introducir el texto");
                int numLinea = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduzca la posicion");
                int posicion = Convert.ToInt32(Console.ReadLine());

                try
                {
                    string[] filas = File.ReadAllLines(rutaTextoTres);

                    if (numLinea >= 1 && numLinea <= filas.Length)
                    {
                        string linea = filas[numLinea - 1];

                        if (posicion >= 0 && posicion <= linea.Length)
                        {
                            string nuevaLinea = linea.Insert(posicion, textoUsuario);

                            filas[numLinea - 1] = nuevaLinea;

                            File.WriteAllLines(rutaTextoTres, filas);

                            Console.WriteLine("El texto ha sido introducido correctamente");
                        }
                        else
                        {
                            Console.WriteLine("la posicion indicada no corresponde con el texto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("la línea indicada no corresponde con el texto");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
                }

            }



        }
    }
}