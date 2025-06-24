public class Insertion_Operation2 {
   public static void main(String[] args) {
      int LA[] = new int[3];
      int n = LA.length;
      System.out.println("Array Before Deletion:");
      for (int i = 0; i < n; i++) {
         LA[i] = i + 3;
         System.out.println("LA[" + i + "] = " + LA[i]);
      }
      for (int i = 0; i < n; i++) {
         LA[i] = LA[i + 1];
         n = n - 1;
      }
      System.out.println("Array After Deletion:");
      for (int i = 0; i < n; i++) {
         System.out.println("LA[" + i + "] = " + LA[i]);
      }

   }
}
