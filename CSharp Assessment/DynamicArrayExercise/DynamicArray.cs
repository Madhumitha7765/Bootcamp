using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayExercise
{
    public class DynamicArray<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public DynamicArray(int initialCapacity)
        {
            if (initialCapacity <= 0)
            {
                Logger.Log("Initial capacity must be greater than zero.");
                return;
            }

            capacity = initialCapacity;
            array = new T[capacity];
            size = 0;
        }

        public void Add(int index, T value)
        {
            if (index < 0 || index > size)
            {
                Logger.Log("Index out of range.");
                return;
            }

            if (size == capacity)
                ResizeArray();

            for (int i = size; i > index; i--)
            {
                array[i] = array[i - 1];
            }

            array[index] = value;
            size++;

            Logger.Log($"Added value: {value} at index: {index}");
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                {
                    Logger.Log("Index out of range.");
                    return default(T); 
                }

                return array[index];
            }
        }

        public int Count
        {
            get { return size; }
        }

        private void ResizeArray()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }
    }
}
