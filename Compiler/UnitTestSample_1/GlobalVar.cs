using JavaScript;

namespace UnitTestSample_1
{
    public class GlobalVar
    {
        [GlobalVariable]
        private int x;

        private void Step1()
        {
            x = 10;
        }

        private void Step2()
        {
            x++;
        }

        public void Do()
        {
            Step1();
            Step2();
        }
    }
}
