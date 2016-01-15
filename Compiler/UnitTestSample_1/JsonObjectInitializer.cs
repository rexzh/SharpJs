using JavaScript;

namespace UnitTestSample_1
{

    public class JsonObjectInitializer
    {
        public void FollowClass()
        {
            var p = new Point() { x = 0, y = 1 };
        }

        public void EmptyListInit()
        {
            var l = new System.Collections.ArrayList()
            {
            };
        }

        public void ListInit()
        {
            var l = new System.Collections.ArrayList()
            {
                1, 2, 3, 4
            };
        }

        public void EmptyGenericListInit()
        {
            var l = new System.Collections.Generic.List<int>()
            {
            };
        }

        public void GenericListInit()
        {
            var l = new System.Collections.Generic.List<int>()
            {
                1, 2, 3, 4
            };
        }

        public void EmptyHashTableInit()
        {
            var t = new System.Collections.Hashtable()
            {
            };
        }

        public void HashTableInit()
        {
            var t = new System.Collections.Hashtable()
            {
                {"x", 1 },
                {"y", 2 }
            };
        }

        public void EmptyDictionaryInit()
        {
            var t = new System.Collections.Generic.Dictionary<string, int>()
            {
            };
        }

        public void DictionaryInit()
        {
            var t = new System.Collections.Generic.Dictionary<string, int>()
            {
                {"x", 1 },
                {"y", 2 }
            };
        }

        public void DictionaryInit2()
        {
            var t = new System.Collections.Generic.Dictionary<string, int>()
            {
                ["x"] = 1,
                ["y"] = 2
            };
        }
    }

    [NoCompile]
    class Point
    {
        public int x;
        public int y;
    }
}
