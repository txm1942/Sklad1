using System.Collections;

namespace Sklad
{
public class Sklad<T>       
    {
        private List<T> Items;

        public Sklad(){
            Items = new List<T>();
        }

        public void AddItem(T item){
            Items.Add(item);
        }

        public void Removeitem(T item){
            Items.Remove(item);

        }

         public List<T> GetItems(){
            return Items;
        }





    }
}