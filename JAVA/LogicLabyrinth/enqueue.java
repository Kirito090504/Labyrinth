package queueoperations;

import java.util.LinkedList;
import java.util.Queue;

public class enqueue {
    public static void main(String[] args) {
Queue<Integer> q = new LinkedList<>();
q.add(6);
q.add(1);
q.add(8);
q.add(4);
q.add(7);
System.out.println("The queue is: " + q);
}
}


