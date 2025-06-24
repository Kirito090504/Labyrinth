package queueoperations;

import java.io.*;

public class isEmpty {

    private int intArray[];
    private int front;
    private int rear;
    private int itemCount;
    private int MAX;

    isEmpty(int size) {
        intArray = new int[size];
        front = 0;
        rear = -1;
        MAX = size;
        itemCount = 0;
    }

    public boolean isEmpty() {
        return itemCount == 0;
    }

    public static void main(String[] args) {
        isEmpty q = new isEmpty(5);
        System.out.println("Stack Empty? " + q.isEmpty());
    }
}
