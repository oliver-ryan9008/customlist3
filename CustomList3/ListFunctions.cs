using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList3
{
    public class ListFunctions<T>
    {
        private int count;
        public int ArrayLength { get; set; }
        public int ArrayCount
        {
            get { return count; }
        }
        public T[] MyArray { get; set; }

        public ListFunctions()
        {
            MyArray = new T[1];

        }

        // Indexer
        public T this[int i]
        {
            get { return MyArray[i]; }
            set { MyArray[i] = value; }
        }


        public void AddList(T elementToAdd)
        {
            if (ArrayLength == ArrayCount)
            {
                ArrayLength += 1;
                T[] myNewArray = new T[ArrayLength];

                for (int i = 0; i < ArrayCount; i++)
                {
                    myNewArray[i] = MyArray[i];
                }

                MyArray = myNewArray;
            }

            MyArray[ArrayCount] = elementToAdd;
            count++;
        }

        public bool RemovedList(T itemToRemove)
        {

            for (int i = 0; i < ArrayCount; i++)
            {
                if (MyArray[i].Equals(itemToRemove))
                {
                    count--;
                    MoveArrayIndexes(i);
                    return true;
                }

            }

            return false;

        }

        public void MoveArrayIndexes(int index)
        {
            T[] myNewArray = new T[ArrayLength];
            for (int i = index; i < ArrayCount; i++)
            {
                myNewArray[i] = MyArray[i + 1];
            }

            myNewArray = MyArray;
        }

        public int CountArrayLength()
        {
            return ArrayLength;
        }

        public override string ToString()
        {
            //StringBuilder sb = new StringBuilder();
            string convertedStringArray = "";
            if (ArrayCount != 0)
            {
                for (int i = 0; i < ArrayCount; i++)
                    convertedStringArray = Convert.ToString(MyArray[i]);
            }

            return convertedStringArray;
        }
    }
}
