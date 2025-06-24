package queueoperations;

import java.io.*;

public class isFull {

    private int intArray[];
    private int front;
    private int rear;
    private int itemCount;
    private int MAX;

    isFull(int size) {
        intArray = new int[size];
        front = 0;
        rear = -1;
        MAX = size;
        itemCount = 0;
    }

    public boolean isFull() {
        return itemCount == MAX;
    }

    public void insert(int key) {
        if (!isFull()) {
            if (rear == MAX - 1) {
                rear = -1;
            }
            intArray[++rear] = key;
            itemCount++;
        }
    }

    public static void main(String[] args) {
        isFull q = new isFull(5);
        q.insert(1); // inserting 1 in the stack
        q.insert(2);
        q.insert(3);
        q.insert(4);
        q.insert(5);
        System.out.println("Stack Full? " + q.isFull());
    }
}
