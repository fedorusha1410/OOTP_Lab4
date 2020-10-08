using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{

    class Stack
    {
        public int[] StackOne;
        private int i = 0;
        public int buf;
        public Stack()
        {
            StackOne = new int[10];
        }
        public Stack(int size)
        {
            StackOne = new int[size];
        }
        public static Stack operator +(Stack stack, int value)
        {
            stack.StackOne[stack.i++] = value;
            return stack;

        }
        public static Stack operator --(Stack stack)
        {
            stack.buf = stack.StackOne[--stack.i];
            return stack;
        }
        public static bool operator true(Stack stack)
        {
            if (stack.buf == 0) return true;
            else return false;
        }
        public static bool operator false(Stack stack)
        {
            if (stack.buf != 0) return false;
            else return true;
        }
        public static Stack operator <(Stack stack1, Stack stack2)
        {
            int[] arr = new int[1];
            return stack2;
        }
        public static int operator >(Stack stack, Stack stack2)
        {
            int tmp;
            stack.buf = stack2.buf;
            for (int i = 0; i < stack.buf; i++)
            {
                stack2.StackOne[i] = stack.StackOne[i];
            }
            for (int i = 0; i < stack2.buf; i++)
            {
                if (stack2.StackOne[i] > stack2.StackOne[i + 1])
                {
                    tmp = stack2.StackOne[i];
                    stack2.StackOne[i] = stack2.StackOne[i + 1];
                    stack2.StackOne[i + 1] = tmp;
                }
            }
            return stack2;
        }
//доделать методы расширения 
//вывод!!!!!
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
