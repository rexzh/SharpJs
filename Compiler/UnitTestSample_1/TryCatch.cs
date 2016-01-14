using JavaScript;

namespace UnitTestSample_1
{
    class TryCatch
    {
        private void DoSomething()
        {
            throw new Error("err");
        }

        private void DoClean()
        {
        }

        private void DoHandle(object obj)
        {
        }

        public void TC()
        {
            try
            {
                DoSomething();
            }
            catch (Error e)
            {
                DoHandle(e);
            }
        }

        public void TC1()
        {
            try
            {
                DoSomething();
            }
            catch
            {
                DoHandle(null);
            }
        }

        public void TF()
        {
            try
            {
                DoSomething();
            }
            finally
            {
                this.DoClean();
            }
        }

        public void TCF()
        {
            try
            {
                DoSomething();
            }
            catch (EvalError e)
            {
                DoHandle(e);
            }
            finally
            {
                DoClean();
            }
        }

        public void MultiCatch()
        {
            try
            {
                DoSomething();
            }
            catch (EvalError e)
            {
                DoHandle(e);
            }
            catch (RangeError e)
            {
                DoHandle(e);
            }
            catch
            {
                DoHandle(null);
            }
            finally
            {
                DoClean();
            }
        }
    }
}
