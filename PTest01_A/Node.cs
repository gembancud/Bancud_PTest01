﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTest01_A
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T data, Node<T> prev, Node<T> next)
        {
            Data = data;
            Next = next;
            Prev = prev;
        }

        public Node(T data)
        {
            Data = data;
        }
    }
}
