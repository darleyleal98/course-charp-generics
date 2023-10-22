using System;
using System.Collections.Generic;

namespace GenercisCourse
{
    public class CalculationService
    {
        public Type MaxValue<Type>(List<Type> list) where Type : IComparable
        {
            if (list == null || list.Count == 0)
            {
                throw new ArgumentNullException("The list can't be empty!");
            }
            Type max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
