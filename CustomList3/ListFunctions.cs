using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList3
{
    public class ListFunctions<T> : IEnumerable<T>
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
            if (ArrayLength == count)
            {
                ArrayLength += 1;
                T[] myNewArray = new T[ArrayLength];

                for (int i = 0; i < count; i++)
                {
                    myNewArray[i] = MyArray[i];
                }

                MyArray = myNewArray;
            }

            MyArray[count] = elementToAdd;
            count++;
        }

        public void RemovedList(T itemToRemove)
        {
            T[] newRemovedArray = new T[ArrayLength];
            for (var n = 0; n < ArrayLength; n++)
            {
                if (MyArray[n] != null)
                {
                    if (MyArray[n].Equals(itemToRemove))
                    {
                        int removeIndex = n;
                        int i = 0;
                        int j = 0;
                        while (i < ArrayLength)
                        {
                            if (i != removeIndex)
                            {
                                newRemovedArray[j] = MyArray[i];
                                j++;
                            }

                            i++;
                        }

                        MyArray = newRemovedArray;
                    }
                    
                }
            }
        }

        public void MoveArrayIndexes(int index)
        {
            T[] myNewArray = new T[ArrayLength];
            for (int i = index; i < count; i++)
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
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                    convertedStringArray = Convert.ToString(MyArray[i]);
            }

            return convertedStringArray;
        }

        public static ListFunctions<T> operator +(ListFunctions<T> one, ListFunctions<T> two)
        {
            ListFunctions<T> currentList = new ListFunctions<T>();

            for (var i = 0; i < one.ArrayLength; i++)
            {
                currentList.AddList(one[i]);
            }

            for (var j = 0; j < two.ArrayLength; j++)
            {
                currentList.AddList(two[j]);
            }


            return currentList;
        }

        public static ListFunctions<T> operator -(ListFunctions<T> one, ListFunctions<T> two)
        {
            ListFunctions<T> currentList = new ListFunctions<T>();

            for (var i = 0; i < one.ArrayLength; i++)
            {
                currentList.AddList(one[i]);
            }

            for (var j = 0; j < two.ArrayLength; j++)
            {
                if (!currentList.Contains(two[j]))
                {
                    currentList.AddList(two[j]);
                }
            }

            return currentList;
        }

        public ListFunctions<T> ZipList(ListFunctions<T> two)
        {
            ListFunctions<T> newList = new ListFunctions<T>();
            int i = 0;

            if (count > two.count)
            {
                while (i < two.count)
                {
                    newList.AddList(MyArray[i]);
                    newList.AddList(two[i]);

                    i++;
                }
                newList.AddList(MyArray[i]);
                i++;
            }
            else if (count < two.count)
            {
                while (i < count)
                {
                    newList.AddList(MyArray[i]);
                    newList.AddList(two[i]);

                    i++;
                }
                newList.AddList(MyArray[i]);
                i++;
            }
            else
            {
                while (i < count)
                {
                    newList.AddList(MyArray[i]);
                    newList.AddList(two[i]);

                    i++;
                }
            }

            return newList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return MyArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
