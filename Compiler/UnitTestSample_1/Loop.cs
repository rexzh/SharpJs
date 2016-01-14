using System;

namespace UnitTestSample_1
{
    public class Loop
    {
        private int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
        private int[] arr2 = { 1, 2, 3, 4, 5 };

        public void ForFunc()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i]++;
            }
        }

        public void ForEachFunc()
        {
            foreach (var a in arr2)
            {
                var b = a;
            }
        }

        public int ContinueBreakFunc()
        {
            var idx = -1;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                    continue;
                else
                {
                    idx = i;
                    break;
                }
            }
            return idx;
        }

        public void WhileFunc()
        {
            int l = arr1.Length;
            while (l > 0)
            {
                if (arr1[l] < 0)
                    break;
                l--;
            }
        }

        public int DoWhileFunc()
        {
            uint idx = 0;
            int count = 0;
            do
            {
                if (arr2[idx] > 0)
                {
                    count++;

                }
                idx++;
            } while (idx < arr2.Length);
            return count;
        }
    }
}
