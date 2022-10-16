using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu4
{
    internal class Sort
    {
        public static void QuickSort(int[] arr, int left, int right)
        {
            int lijevo = left, desno = right;
            int x = arr[(left + right) / 2];
            do
            {
                while (arr[lijevo] > x && lijevo < right)
                    lijevo++;
                while (arr[desno] < x && desno > left)
                    desno--;
                if (lijevo <= desno)
                {
                    int temp = arr[lijevo]; arr[lijevo] = arr[desno]; arr[desno] = temp;
                    lijevo++;
                    desno--;
                }
            }
            while (lijevo <= desno);
            if (left < desno)
                QuickSort(arr, left, desno);
            if (lijevo < right)
                QuickSort(arr, lijevo, right);
        }
    }
}
