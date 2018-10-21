using System;

namespace Stack
{
    class Stack <T>
    {
        /// <summary>
        /// 
        /// </summary>
        private int maxSize ;
        private int currentSize;
        private T[] intArray;
        /// <summary>
        /// The class constructor
        /// </summary>
        public Stack()
        {
            maxSize = new int();
            currentSize = new int();
            intArray = new T[maxSize];
        }
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="size"></param>
        public Stack(int size)
        {
            maxSize = new int();
            currentSize = new int();
            maxSize = size;
            currentSize = size;
            intArray = new T[maxSize];
        }
        /// <summary>
        /// The class constructor 
        /// </summary>
        /// <param name="initialArray"></param>
        public Stack(T[] initialArray)
        {
            maxSize = new int();
            currentSize = new int();
            maxSize = initialArray.Length;
            currentSize = 0;
            intArray = new T[maxSize];
            for (int i = 0; i < initialArray.Length;i++)
            {
                currentSize++;
                intArray[i] = initialArray[i];
            }
        }
        /// <summary>
        /// Resize the stack to <param> size
        /// </summary>
        /// <param name="newMaxSize"></param>
        public void Resize (int newMaxSize)
        {
            maxSize = newMaxSize;
            int counter = new int();
            counter = 0;

            T[] temporaryArray = new T[maxSize];
            foreach (T i in intArray)
            {
                temporaryArray[counter] = i;
                counter++;
            }
            intArray = temporaryArray;
        }
        /// <summary>
        /// Remove the first element from stack
        /// </summary>
        /// <returns>Retrun <int> the first elemnt of stack</returns>
        public T Pop ()
        {
            try
                {
                T headElement ;
                headElement = intArray[0];
                for (int i = 0; i < maxSize - 1; i++)
                {
                    intArray[i] = intArray[i + 1];
                }

                currentSize--;
                return headElement;
            }
            catch (Exception e)
            {
                throw new Exception("No elemets in stack");
            }
        }
        /// <summary>
        /// Push new element to stack
        /// </summary>
        /// <param name="newElement"></param>
        public void Push (T newElement)
        {
            try
            {
                if (currentSize >= maxSize)
                {
                    Resize(maxSize * 2);
                }
                for (int i = maxSize - 1; i > 0; i--)
                {
                    intArray[i] = intArray[i - 1];
                }
                intArray[0] = newElement;
                currentSize++;
            }catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        /// <summary>
        /// Return the head element of stack
        /// </summary>
        /// <returns>Return <int> the head element of stack </returns>
        public T GetHead ()
        {
            T headElement ;
            try
            {
                headElement = intArray[0];
                return headElement;
            }
            catch (Exception e)
            {
                throw new Exception("No elemets in stack");
            }
        }
    }
}