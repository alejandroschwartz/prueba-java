using System;

namespace consoleProject
{
  public class TelefonoUtils
  {
    public static void imprimirTitulo(string texto)
    {
      Console.WriteLine();
      Console.WriteLine(texto);
      Console.WriteLine();
    }

    public static void resultado(String[] numeros)
    {
      String resp = "";
      for (int j = 0; j < numeros.Length; j++)
      {
        resp = resp + numeros[j] + " ";
      }
      imprimirTitulo(resp);
    }

    public static String[] miSwitch(char[] cadena)
    // public static String[] miSwitch(String[] cadena)
    {
      String[] numeros = new String[cadena.Length];

      for (int i = 0; i < cadena.Length; i++)
      {
        switch (cadena[i].ToString())
        {
          case "a":
            numeros[i] = "2";
            break;
          case "b":
            numeros[i] = "22";
            break;
          case "c":
            numeros[i] = "222";
            break;
          case "d":
            numeros[i] = "3";
            break;
          case "e":
            numeros[i] = "33";
            break;
          case "f":
            numeros[i] = "333";
            break;
          case "g":
            numeros[i] = "4";
            break;
          case "h":
            numeros[i] = "44";
            break;
          case "i":
            numeros[i] = "444";
            break;
          case "j":
            numeros[i] = "5";
            break;
          case "k":
            numeros[i] = "55";
            break;
          case "l":
            numeros[i] = "555";
            break;
          case "m":
            numeros[i] = "6";
            break;
          case "n":
            numeros[i] = "66";
            break;
          case "o":
            numeros[i] = "666";
            break;
          case "p":
            numeros[i] = "7";
            break;
          case "q":
            numeros[i] = "77";
            break;
          case "r":
            numeros[i] = "777";
            break;
          case "s":
            numeros[i] = "7777";
            break;
          case "t":
            numeros[i] = "8";
            break;
          case "u":
            numeros[i] = "88";
            break;
          case "v":
            numeros[i] = "888";
            break;
          case "w":
            numeros[i] = "9";
            break;
          case "x":
            numeros[i] = "99";
            break;
          case "y":
            numeros[i] = "999";
            break;
          case "z":
            numeros[i] = "9999";
            break;
          case " ":
            numeros[i] = "\n";
            break;
        }
      }
      return numeros;
    }
  }
}