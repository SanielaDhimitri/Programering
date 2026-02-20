using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.ss
{
    public class MyStack
    {

        private int[] _stack;    //A Stack is an ordered list of elements// // Array til elementern
        //private int _size;//The Stack have a given size 
        private int _top; //that add an element to the top of the Stack

        public MyStack(int size)
        {
            _stack = new int[size];//duhet të krijosh një stack bosh me atë madhësi
            //_size = size;
            _top = 0;


        }
        public void Push(int tal) 
        {
            if (_top == _stack.Length)
                throw new MyStackIsFullException ("Stacken is full");
           _stack[_top++]=tal;
          
        }
        public int Pop() 
        {
            if (_top == 0)
                throw new MyStackIsEmptyException("Stacken is empty") ;

            return _stack[--_top];// ikke _top--???Rykker vi forst og bagefter taller vi.
        }
    }
}