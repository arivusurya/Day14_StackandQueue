using System;
using System.Collections.Generic;


public class  MyQueue<T>{
    private LinkedList<T> list = new LinkedList<T>();


    public void Add(T num){
        list.AddLast(num);
    }
    public void dequeue(){
        if(list.Count == 0){
            Console.WriteLine("List is empty");
            return;
        }
        T item =  list.First.Value;
        list.RemoveFirst();
        Console.WriteLine("The removed element is {0}",item);
    }
    public void Display(){
        if (list.Count == 0){
            Console.WriteLine("list is empty");
        }
        foreach(T item in list){
            Console.WriteLine(item);
        }
    }
}