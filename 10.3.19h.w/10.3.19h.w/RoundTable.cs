using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3._19h.w
{
    class RoundTable<T> : IEnumerable<T> where T:IComparable<T>
    {
        List<T> entities = new List<T>();

        public RoundTable()
        {

        }

        public void Add(T t)
        {
            this.entities.Add(t);
        }

        public void RemoveAt(int b)
        {
            if (entities.Count > b)
            {
                this.entities.RemoveAt(b);
            }
            else if (entities.Count <= b)
            {
                this.entities.RemoveAt(b - entities.Count - 1);
            }
        }

        public void InsertAt(int b, T t)
        {
            if(entities.Count>=b)
            {
                this.entities.Insert(b, t);
            }
            else if(entities.Count<b)
            {
                this.entities.Insert(b - entities.Count, t);
            }
        }

        public void Sort()
        {
            this.entities.Sort();
        }

        public List<T> GetRounded(int b)
        {
            if(entities.Count>=b)
            {
                return entities;
            }
            else 
            {
                List<T> newList = new List<T>();
                newList = entities;
                int i = entities.Count;
                int p = 0;
                while(i<b)
                {
                    newList[i] = entities[p];
                    i++;
                    if(p<entities.Count)
                    {
                        p++;
                    }
                    else
                    {
                        p = 0;
                    }
                }
                return newList;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public T this[int index]
        {
            get
            {
                if (entities.Count < index)
                {
                    return entities[index];
                }
                else
                {
                    int b = 0;
                    while (index > entities.Count)
                    {
                        b = index - entities.Count;
                    }
                    return entities[b - 1];
                }
            }
        }
        
        public T this[string name]
        {
            get
            {
                foreach (T item in entities)
                {
                    if(entities.name==name)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (T item in entities)
            {
                result = result + $"{item}\n";
            }
            return result;
        }
    }
}
