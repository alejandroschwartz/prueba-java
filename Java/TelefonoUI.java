import java.util.Scanner;

public class TelefonoUI {

  public static void showMenu() {
    int respuesta = 0;

    do {
      TelefonoUtils.imprimir("Bienvenido!");
      System.out.println("Seleciones una opcion:");
      System.out.println("1. Covertir palabra a numero");
      System.out.println("0. Salir");

      System.out.println();
      System.out.print("Ingrese opcion: ");
      Scanner scanner = new Scanner(System.in);

      respuesta = Integer.valueOf(scanner.nextLine());

      switch (respuesta) {
        case 0:
          TelefonoUtils.imprimir("! Se terminó el programa.");
          break;
        case 1:
          TelefonoUtils.imprimir("Convertir palabra a numero");

          System.out.print("Introduzca el texto: ");
          Scanner entrada = new Scanner(System.in);
          String nombre = entrada.nextLine().toLowerCase();

          String[] cadena = nombre.split("");
          String[] num = TelefonoUtils.miSwitch(cadena);
          TelefonoUtils.resultado(num);
          break;
        default:
          TelefonoUtils.imprimir("! Selecciona una opción correcta.");
      }
    } while (respuesta != 0);

  }
}
