using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sorting_W8
{
    public class quickSorts
    {
        public int parts(int[] items, int left, int right)
        { 
            int pivot = items[left];
            int i = left;
            int j = right;

            while (i < j && items[i] <= pivot) {
                    i++;
            }
             
            while (i < j && items[j] >= pivot) {
                 j--;
            }
            
            if (i < j) {
                (items[i], items[j]) = (items[j], items[i]);
            }

            (items[i], items[left]) = (items[left], items[i]);
            return i;
        }

        public void quickSort(int[] items, int left, int right)
        {
            if (left < right)
            {
                int pivot = parts(items, left, right);
                quickSort(items, left, pivot - 1);
                quickSort(items, pivot + 1, right);
            }
        }
    }
}
