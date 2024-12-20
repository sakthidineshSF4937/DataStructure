using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    /// <summary>
    /// Class CustomStack <see cref="CustomStack"/> used for creating instance for a CustomStack/>
    /// </summary>
    public class CustomStack<Type>
    {
        /// <summary>       
        /// field count to provide  for an instance of <see cref="CustomStack"/> 
        /// </summary>
        /// <value></value>
       private int _count;
       /// <summary>       
        /// field capacity to provide  for an instance of <see cref="CustomStack"/> 
        /// </summary>
        /// <value></value>
       private int _capacity;
       /// <summary>       
        /// field top to provide  for an instance of <see cref="CustomStack"/> 
        /// </summary>
        /// <value></value>
       private int _top;

    
       public Type [] _array;  
/// <summary>
///     This constructor is used to initialize the values
/// </summary>
       public CustomStack(){
        _count=0;
        _top=-1;
        _capacity=4;
        _array=new Type[_capacity];
       }
       public CustomStack(int size){
          _count=0;
          _top=-1;
          _capacity=size;
          _array =new Type[_capacity];
       }
/// <summary>
/// This is used add the element
/// </summary>
/// <param name="element"></param>
       public void Push(Type element){
        if(_top==_capacity){
            GrowSize();
        }

        _array[_top+1]=element;
        _top++;
       }
       /// <summary>
       /// GrowSize method is used to increase the size
       /// </summary>
       public void GrowSize(){
        _capacity=_capacity*2;
        Type[] temp=new Type[_capacity];
        for(int i=0;i<_top;i++){
            temp[i]=_array[i];
        }
        _array=temp;
       }
       /// <summary>
       /// The peek Method is used to display the first element 
       /// </summary>
       /// <returns></returns>
       public Type peek(){
        if(_top==-1){
            return default(Type);
        }
        else{
            return  _array[_top];
        }
       }
       /// <summary>
       /// It is used to remove the element 
       /// </summary>
       /// <returns></returns>
       public Type pop(){
        if(_top==-1){
            return default(Type);
        }
        else{
            _top--;
            return _array[_top+1];
        }
       }
    }
}