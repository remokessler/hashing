using System.Collections.Generic;

namespace SortComparison.SortingAlgorithms
{
    public class ShellSort : SortAlgorithm
    {
        public override string Name => "Shellsort";

        public override void Sort(IList<int> arrayToSort)
        {
            int i, j, inc, temp;
            inc = arrayToSort.Count / 4;
            while (inc > 0)
            {
                for (i = 0; i < arrayToSort.Count; i++)
                {
                    j = i;
                    temp = arrayToSort[i];
                    while ((j >= inc) && (arrayToSort[j - inc] > temp))
                    {
                        arrayToSort[j] = arrayToSort[j - inc];
                        j = j - inc;
                    }
                    arrayToSort[j] = temp;
                }
                if (inc / 2 != 0)
                {
                    inc = inc / 2;
                }
                else if (inc == 1)
                {
                    inc = 0;
                }
                else
                {
                    inc = 1;
                }
            }
        }
    }
}
