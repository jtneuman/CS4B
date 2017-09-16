using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecializedCollections.Interfaces;
using SpecializedCollections.Classes;

namespace SpecializedCollections.Classes
{
    public class Repository<T> where T : class, IRegisterable, new()
    {
        List<T> items = new List<T>();


        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerable<T> Get(bool? registered = null)
        {
            // If registered is null then return all items
            // otherwise return registered items if true
            // and not registered items if false
            if (registered == null)
            {
                return items;
            }
            else
            {
                return items.Where(item =>
                    item.IsRegistered.Equals(registered));
            }
        }
    }

}
