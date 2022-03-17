﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        internal Node head;
        //method for add element
        internal void Add(int data)
        {
            //creating a node with given data
            Node node = new Node(data);
            //if head is null means the list is empty
            //the first  node is head
            if (this.head == null)
                this.head = node;
            else
            {
                //esle add the element to the end
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            //print and inserted into the linked list
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        //method for Seconf Linkedlist
        internal void Add2(int data)
        {
            //creating a node with given data
            Node node = new Node(data);
            //if head is null means the list is empty
            //the first  node is head
            if (this.head == null)
                this.head = node;
            else
            {
                //esle add the element to the end
                node.next = head;
                this.head = node;
            }
            //print
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        // for display
        internal void Display()
        {
            Node temp = this.head;
            //if head is null means the list is empty
            if (temp == null)
            {
                //print linked list is empty
                Console.WriteLine("Linked list is empty");
                return;
            }
            // traverse and print data from head to last
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}