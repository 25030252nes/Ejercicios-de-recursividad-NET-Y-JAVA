import java.util.*;

public class Main {
    public static void main(String[] args) {
        System.out.println("Metodos recursivos");
        System.out.println("\n\n calcular factorial de 5");
        Recursividades oRecursividades = new Recursividades();
        int resultado = oRecursividades.CalcularFactorial(5);
        System.out.println("Factorial de 5 es:" + resultado);
        System.out.println("\n--- 1. Contar Vocales ---");
        String texto = "Hola Mundo";
        int cantidadVocales = oRecursividades.vocales(texto);
        System.out.println("La cantidad de vocales en '" + texto + "' es: " + cantidadVocales);
        System.out.println("\n--- 2. Suma de dígitos en secuencia ---");
        int[] secuencia = { 123, 99, 456, 801, 23 };
        int mayorNumero = 0;
        int mayorSuma = -1;
        for (int num : secuencia) {
            int sumaActual = oRecursividades.SumaDigitos(num);
            System.out.println("El número " + num + " tiene una suma de dígitos de: " + sumaActual);
            if (sumaActual > mayorSuma) {
                mayorSuma = sumaActual;
                mayorNumero = num;
            }
        }
        System.out.println("El número con la mayor suma de dígitos es: " + mayorNumero + " (Suma: " + mayorSuma + ")");
        System.out.println("\n--- 3. Suma de primeros n números ---");
        int n = 5;
        int sumaTotal = oRecursividades.SumarNumeros(n);
        System.out.println("La suma de los primeros " + n + " números enteros es: " + sumaTotal);
    }
}

class Recursividades {
    public int CalcularFactorial(int num) {
        if(num==1) {
            return 1;
        }
        return num * CalcularFactorial(num - 1);
    }
    public int vocales(String cadena) {
        if (cadena == null || cadena.isEmpty()) {
            return 0;
        }
        char c = Character.toLowerCase(cadena.charAt(0));
        int esVocal = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') ? 1 : 0;
        return esVocal + vocales(cadena.substring(1));
    }
    public int SumaDigitos(int num) {
        if (num < 10) {
            return num;
        }
        return (num % 10) + SumaDigitos(num / 10);
    }
    public int SumarNumeros(int n) {
        if (n <= 1) {
            return n;
        }
        return SumarNumeros(n - 1) + n;
    }
}