using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{

    class ArrayList
    {
        object[] thisArray;
        public int Size = 0;

        public int arraySize
        {
            set
            {

            }
            get
            {
                return thisArray.Length;
            }
        }
        public ArrayList ()
        {
            thisArray = new object[Size];
        }
        public virtual void Add(object value)
        {
            object[] newArray = new object[arraySize + 1];
            newArray[arraySize] = value;
            

            //set empty values in new array to values in old array
            for (int i = 0; i < thisArray.Length; i++)
            {
                newArray[i] = thisArray[i];
            }
            //set old array to new array
            thisArray = newArray;

            arraySize++;

            return;
        }
        public virtual void Clear()
        {
            for (int i = 0; i < arraySize; i++)
            {
                thisArray[i] = null;
            }
        }
        public virtual object this[int index]
        {
            set
            {
                thisArray[index] = value; 
            }
            get
            {
                return thisArray[index];
            }
        }
    }
}
