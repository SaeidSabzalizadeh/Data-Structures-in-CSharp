﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Structures
{
    public class LinkedListSelfImplement
    {
        public class SinglyLinkedList
        {
            private Node first;
            public bool isEmpty()
            {
                return (first == null);
            }

            public void insertFirst(int data)
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = first;
                first = newNode;
            }

            public Node deleteFirst()
            {
                Node temp = first;
                first = first.next;
                return temp;
            }

            public void displayList()
            {
                Console.WriteLine("List (first -- last) ");
                Node current = first;
                while (current != null)
                {
                    current.displayNode();
                    current = current.next;
                }
                Console.WriteLine();
            }

            public void insertLast(int data)
            {
                Node current = first;
                while (current.next != null)
                {
                    current = current.next;
                }

                Node newNode = new Node();
                newNode.data = data;
                current.next = newNode;
            }
        }

        public class Node
        {
            public int data;
            public Node next;

            public void displayNode()
            {
                Console.WriteLine("<" + data + ">");
            }
        }

    }
}
