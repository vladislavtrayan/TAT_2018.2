using System;

namespace lab_27._10._18
{
    /// <summary>
    /// LinkedList is a doubly linked list 
    /// Provides methods to add elements into list ,
    /// to add elements into head of list,
    /// and to search 
    /// </summary>
    class LinkedList
    {
        private Node head;
        private Node tail;
        private int elementCounter;

        /// <summary>
        /// Add new Car element to list 
        /// </summary>
        /// <param name="newElement"></param>
        /// <returns>
        /// true if there are no exceptions 
        /// if not throw new exception ("Can't add element")
        /// </returns>
        public bool AddElement (Car newElement)
        {
            try
            {
                Node newNode = new Node(newElement);
                if (head == null)
                {
                    newNode.NextNode = tail;
                    tail = newNode;
                    head = newNode;
                }
                else
                {
                    tail.NextNode = newNode;
                    newNode.PreviosNode = tail;
                    tail = newNode;
                }
                elementCounter++;

                return true;
            } catch
            {
                throw new Exception("Can't add element");
            }
        }

        /// <summary>
        /// Search the objects 
        /// which have one or more same fields as a argument
        /// </summary>
        /// <param name="searchElement"></param>
        /// <returns>
        /// LinkedList of objects which have one or more same fields
        /// </returns>
        public LinkedList Search (Car searchElement) 
        {
            LinkedList newCarList = new LinkedList ();
            Node temporaryNode = new Node();
            temporaryNode = head;
            int indexCounter = 0;
            while (temporaryNode != null)
            {
                if (temporaryNode.Data.Brand == searchElement.Brand || 
                    temporaryNode.Data.Color == searchElement.Color || 
                    temporaryNode.Data.Model == searchElement.Model)
                {
                    newCarList.AddElement(temporaryNode.Data);
                    indexCounter++;
                }
                temporaryNode = temporaryNode.NextNode;
            }
            return newCarList;
        }
        /// <summary>
        /// Add new element to head of list
        /// </summary>
        /// <param name="newElement"></param>
        /// <returns>
        /// true if there are no exceptions 
        /// if not throw new exception ("Can't add element to head of list")
        /// </returns>
        public bool AddHead (Car newElement)
        {
            try
            {
                Node newNode = new Node(newElement);
                head.PreviosNode = newNode;
                newNode.NextNode = head;
                head = newNode;
                elementCounter++;

                return true;
            } catch
            {
                throw new Exception("Can't add element to head of list");
            }
        }
        /// <summary>
        /// display all elements of list in console
        /// </summary>
        public void OutPut ()
        {
            try
            {
                Node temporaryNode = new Node();
                temporaryNode = head;
                while (temporaryNode != null)
                {
                    Console.Write("Car brand : " + temporaryNode.Data.Brand + 
                        " , model : " + temporaryNode.Data.Model +
                        " , color : "+ temporaryNode.Data.Color + " ");
                    temporaryNode = temporaryNode.NextNode;
                }
            } catch
            {
                throw new Exception("Can't output list");
            }
        }
    }
}
