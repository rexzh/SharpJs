using JavaScript;
using JavaScript.Compatible;

namespace JsSample
{
    [RenameClass("")]
    [NoCompile]
    public class Cast
    {
        [RenameMember("")]
        public static T To<T>(object o)
        {
            return (T)o;
        }
    }

    public class SampleApp
    {
        //public void Test2(int[] arr)
        //{
        //    var l = arr.Length;
        //}

        //private string s;
        //public void BX(Point p)
        //{
        //    var x = p?.X;
        //    var str = $"({p.X}, {p.Y})";
        //}

        //public void Init(int i)
        //{
        //    var p = new Point() { X = 1, Y = 1 };
        //    System.Collections.Generic.Dictionary<int, string> d1 = new System.Collections.Generic.Dictionary<int, string>()
        //        {
        //            { 1, "One"},
        //            { 2, "Two"}
        //        };

        //    System.Collections.Generic.Dictionary<int, string> d2 = new System.Collections.Generic.Dictionary<int, string>()
        //    {
        //        [1] = "One",
        //        [2] = "Two"
        //    };

        //    System.Collections.Hashtable h = new System.Collections.Hashtable()
        //    {
        //        ["s"] = "g",
        //        ["t"] = "v"
        //    };
        //}

        //public void Test()
        //{
        //    int[] arr = new int[] { 1, 2, 3 };
        //    arr.Push(new int[] { 5, 6 });

        //    String str = "123";
        //}

        //public void G()
        //{
        //    var obj = new object();
        //    var e = obj as JavaScript.Object;
        //    foreach (var p in e)
        //    {
        //        var v = e[p];
        //    }

        //    string str = "";
        //    var l = str.Length;
        //}

        //public int Z(string[] array)
        //{
        //    System.Func<int> f = () => 1;

        //    var b = f();
        //    //X++;
        //    var i = array.Length;
        //    return 0;
        //}
    }

    [NoCompile]
    public class Point : JavaScript.Object
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    [NoCompile]
    public class Line
    {
        public Point A { get; set; }
        public Point B { get; set; }
    }


    [NoCompile]
    public interface IRun
    {
    }
}