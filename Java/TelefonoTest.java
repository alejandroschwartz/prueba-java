import java.util.Arrays;

public class TelefonoTest {

  public static void main(String args[]) {
    
    String prueba1 = "hi";
    String[] salida1 = {"44", "444"};
    String[] result1 = TelefonoUtils.miSwitch(prueba1.split(""));
    if( Arrays.toString(result1).equals(Arrays.toString(salida1))) {
      System.out.println("OK - test1");
    } else {
      System.out.println("ERROR - test1");
    }

    String prueba2 = "yes";
    String[] salida2 = {"999", "33", "7777"};
    String[] result2 = TelefonoUtils.miSwitch(prueba2.split(""));
    if( Arrays.toString(result2).equals(Arrays.toString(salida2))) {
      System.out.println("OK - test2");
    } else {
      System.out.println("ERROR - test2");
    }

    String prueba3 = "foo bar"; 
    String[] salida3 = {"333", "666", "666", "\n", "22", "2", "777"};
    String[] result3 = TelefonoUtils.miSwitch(prueba3.split(""));
    if( !Arrays.toString(result3).equals(Arrays.toString(salida3))) {
      System.out.println("ERROR - test3");
    } else {
      System.out.println("OK - test3");
    }

    String prueba4 = "hello world";
    String[] salida4 = {"44", "33", "555", "555", "666", "\n", "9", "666", "777", "555", "3"};
    String[] result4 = TelefonoUtils.miSwitch(prueba4.split(""));
    if( !Arrays.toString(result4).equals(Arrays.toString(salida4))) {
      System.out.println("ERROR - test4");
    } else {
      System.out.println("OK - test4");
    }

  }
}
