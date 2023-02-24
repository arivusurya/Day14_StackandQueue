using System;
using System.Collections.Generic;

public class Mystack <T>{
    private LinkedList<T> list = new LinkedList<T>();

    public void Push(T num){
        list.AddFirst(num);
    }  
 
}