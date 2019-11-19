using System.Collections.Generic;
using System.Linq;

namespace CodeTest.Vectors
{
    public class VectorService
    {
        public List<int> Filter(List<int> elements)
        {
            if (elements != null)
            {
                var resp = ValidateToResponseZero(elements);
                resp = resp ?? ValidateToResponseEvensPlusTotal(elements);

                return resp;
            }

            return new List<int>();
        }

        private List<int> ValidateToResponseZero(List<int> elements)
        {
            if (elements.Count == 0 || elements.All(x => x % 2 != 0))
                return new List<int> { 0 };

            return null;
        }

        private List<int> ValidateToResponseEvensPlusTotal(List<int> elements)
        {
            var newList = elements.Where(x => x % 2 == 0).ToList();
            newList.Add(newList.Count);

            return newList;
        }



    }
}
