using System;
using System.Collections.Generic;
using System.Text;

namespace _17;

// Definition eines type constraints, d.h dier schränkt die möglich
// Type-Argumente ein --> es dürfen nur mehr Klassen verwendet werden, die das
// Interface IDrawable implementieren
public class Repository<T> // where T : Interface
{
    private readonly List<T> items = new List<T>();

    public Repository() { }
    public Repository(List<T> values)
    {
        items = values;
    }

    public void Add(T item)
    {
        items.Add(item);
    }

    public bool Remove(T item)
    {
        return items.Remove(item);
    }

    public IEnumerable<T> GetAll()
    {
        return items;
    }
}
