using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecializedCollections.Interfaces;

namespace SpecializedCollections.Classes
{
    public static class Extensions
    {
        // Because Repository<T> class has constraints, this method must have the same.
        public static IEnumerable<T> Search<T>(this Repository<T> rep,
            string search) where T : class, IRegisterable, new()
        {
            var readProps = typeof(T).GetProperties().Where(p =>
                p.PropertyType.Equals(typeof(string)) && p.CanRead);

            var result = new List<T>();
            foreach (var item in rep.Get())
            {
                if (result.Contains(item)) continue;

                foreach (var prop in readProps)
                {
                    if(item.GetType().GetProperty(prop.Name).GetValue(item)
                        .ToString().ToUpper().Contains(search.ToUpper()))
                    {
                        if (!result.Contains(item))
                        {
                            result.Add(item);
                            continue;
                        }
                    }
                }
                
            }
            return result;
        } // end Search method

        public static void Output<T>(this IEnumerable<T> items, 
            Action<T> print) where T : class, IRegisterable, new()
        {
            foreach (var item in items)
            {
                print(item);
            }
        }
    }
}
