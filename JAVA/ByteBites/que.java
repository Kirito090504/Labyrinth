import java.util.Queue;
import java.util.LinkedList;

public class que {

    public static void main(String[] args) {
        Queue<Double> x = new LinkedList<>();
        x.add(1.1);
        x.add(2.2);
        x.add(3.3);
        x.add(4.4);
        x.add(5.5);
        x.add(6.6);
        System.out.println("The queue is: " + x);

        Double n = x.remove();
        Double m = x.remove();
        System.out.println("The element deleted is: " + n + "," + m);
        System.out.println("Queue after deletion: " + x);
        int size = x.size();
        System.out.println("Size of the queue is:" + size);

    }
}
