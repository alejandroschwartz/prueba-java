using System;

namespace consoleProject
{
  public class TelefonoUI
  {
    public static void mostrarMenu() {
      TelefonoUtils.imprimirTitulo("Bienvenido");

      int userInteface = 0;
      do
      {
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine(" 1. Ingresar palabra");
        Console.WriteLine(" 0. Salir");
        string selectNum = Console.ReadLine().ToString();

        userInteface = 1;
        switch (selectNum)
        {
          case "0":
            userInteface = 0;
            TelefonoUtils.imprimirTitulo("Programa Finalizado");
            break;
          case "1":
            TelefonoUtils.imprimirTitulo("Introduzca el texto");
            string palabra = Console.ReadLine();

            char[] palabraTrim = new char[palabra.Length];
            for (int i = 0; i < palabra.Length; i++)
            {
              palabraTrim[i] = palabra[i];
            }

            String[] numeros = TelefonoUtils.miSwitch(palabraTrim);
            TelefonoUtils.resultado(numeros);
            break;
          default:
            TelefonoUtils.imprimirTitulo("Seleccione una opcion correcta");
            break;
        }

      } while (userInteface != 0);
    }
  }
}
