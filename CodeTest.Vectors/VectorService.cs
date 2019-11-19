using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest.Vectors
{
    public class VectorService
    {
        public List<int> Filter(List<int> elements)
        {
            if (elements.Count == 0 || elements.All(x => x % 2 != 0))
                return new List<int> { 0 };

            var newList = elements.Where(x => x % 2 == 0).ToList();
            newList.Add(newList.Count);

            return newList;
        }
    }
}
