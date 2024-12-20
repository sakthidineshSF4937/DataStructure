using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queue
{
    //This class is a custom Queue Contains methods for operation in queue
    public class CustomQueue<Type>:IEnumerator,IEnumerable
    {
        //field used to store the count
        private int _count;
        //field is used to store the capacity
        private int _capacity;
        //field is used to store the head value
        private int _head;
        //field is used to track last value
        private int _tail;
        private Type[] _array;
        //Used to initaialze the queue
        public CustomQueue(){
          _count=0;
          _capacity=4;
         _head=0;
         _tail=0;
         _array=new Type[_capacity];       
        }
        //Used to initaialze the queue
        public CustomQueue(int size){
            _count=0;
            _capacity=size;
            _head=0;
            _tail=0;
            _array=new Type[_capacity];
        }

        //this method is used for Adding the element
        public void EnQueue(Type element){
            if(_capacity==_tail){
                 grow();
            }
            _array[_tail]=element;
            _tail++;
            _count++;
        }
        //increase the size after maximizing the list
        public void grow(){
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=_head;i<_tail;i++){
                temp[i]=_array[i];
            }
            _array=temp;
        }
        //Peek method is used to display the first element
        public Type Peek(){
            if(_head==_tail){
                return default(Type);
            }
            else{
                return _array[_head];
            }
        }
        //Method is used to Remove 
        public Type Dequeue(){
            if(_head==_tail){
                  return default(Type);
            }
            else{
                _head++;
                _count--;
                return _array[_head-1];
            }
        }
    int position;
        public IEnumerator GetEnumerator(){
        position=_head-1;
        return (IEnumerator) this; 
    }

        public bool MoveNext()
        {
            if(position<_tail-1){
               position++;
               return true;
            }
            else{
                Reset();
                return false;
            }
           
        }
        public void Reset()
        {
            position=_head-1;
           
        }
 
            public object Current {get{return _array[position];}}
    }

}