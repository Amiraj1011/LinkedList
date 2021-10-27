﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// UC1 - simple linked list program
    /// </summary>
    public class LinkedList
    {
        //Creating head variable of node class
        internal Node head;
        //creating add method for adding
        internal void Add(int data)
        {
            //creating node object for Node class
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        //creating display method to show list
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            { 
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        //Creating Add method
        internal void AddFirst(int data)               
        {
            //creating a node object of the Node class
            Node node = new Node(data);                  
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;

            }
            this.head = node;
            Console.WriteLine("{0} inserted into linked list", node.data);

        }
    }
}
