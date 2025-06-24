import java.util.Scanner;

public class Search_Operation {
   public static void main(String[] args) {
      int LA[] = new int[5];
      boolean found = false;
      try (Scanner scanner = new Scanner(System.in)) {

         System.out.println("Array:");
         for (int i = 0; i < 5; i++) {
            LA[i] = i + 3;
            System.out.println("LA[" + i + "] = " + LA[i]);
         }

         System.out.println("Enter the number to search for:");
         int to_search = scanner.nextInt();

         for (int i = 0; i < 5; i++) {
            if (LA[i] == to_search) {
               found = true;
               System.out.println("Element " + to_search + " is found at index " + i);
            }
         }
         if (!found)
            System.out.println("Not found");
      }
   }
}
