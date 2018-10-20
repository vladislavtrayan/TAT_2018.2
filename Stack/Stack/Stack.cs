﻿using System;

namespace Stack
{
    class Stack
    {
        /// <summary>
        /// 
        /// </summary>
        private int maxSize ;
        private int currentSize;
        private int[] intArray;
        /// <summary>
        /// The class constructor
        /// </summary>
        public Stack()
        {
            maxSize = new int();
            currentSize = new int();
            intArray = new int[maxSize];
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
            intArray = new int[maxSize];
        }
        /// <summary>
        /// The class constructor 
        /// </summary>
        /// <param name="initialArray"></param>
        public Stack(int[] initialArray)
        {
            maxSize = new int();
            currentSize = new int();
            maxSize = initialArray.Length;
            currentSize = 0;
            intArray = new int[maxSize];
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

            int[] temporaryArray = new int[maxSize];
            foreach (int i in intArray)
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
        public int Pop ()
        {
            try
                {
                int headElement = new int();
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
        public void Push (int newElement)
        {
            try
            {
                if (currentSize >= maxSize)
                {
                    Resize(maxSize + 1);
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
        public int GetHead ()
        {
            int headElement = new int();
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