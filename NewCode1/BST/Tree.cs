using System;

namespace NewCode1.BST
{
    public class Tree<TKey, TValue> where TKey : IComparable<TKey>
    {
        public Node<TKey, TValue> Root { get; private set; }

        public Node<TKey, TValue> AddNode(TKey key, TValue value)
        {
            if (Root == null)
            {
                Root = new Node<TKey, TValue>(key, value);
            }

            else if (key.CompareTo(Root.Key) < 0)
            {
                Root.Left = new Node<TKey, TValue>(key, value);
            }
            else
            {
                Root.Right = new Node<TKey, TValue>(key, value);
            }

            return Root;
        }

        public TValue FindByKey(TKey key)
        {
            var current = Root;

            while (current != null)
            {
                if (key.CompareTo(key) == 0)
                {
                    return current.Value;
                }

                if (key.CompareTo(key) < 0)
                {
                    current = current.Left;
                }

                if (key.CompareTo(key) > 0)
                {
                    current = current.Right;
                }
            }

            return current.Value;
        }
    }
}