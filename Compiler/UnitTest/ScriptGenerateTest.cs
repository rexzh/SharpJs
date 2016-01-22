using System;
using System.IO;

using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class ScriptGenerateTest
    {
        private string _jsPath = @"..\..\..\UnitTestSample_1\ToCompare";
        private string _outPath = @"..\..\..\UnitTestSample_1\bin\Debug";

        [TestFixtureSetUp]
        public void SetUp()
        {
            SJC.Compiler.CompileEngine engine = new SJC.Compiler.CompileEngine();
            SJC.Compiler.CompileOptions opts = new SJC.Compiler.CompileOptions(SJC.Artifacts.ArtifactsType.MultipleFile, SJC.Compiler.CompileOptions.DEBUG_ANY_CPU, false);
            opts.GenerateSourceMap = false;
            engine.InitializeCompiler(@"..\..\..\UnitTestSample_1\UnitTestSample_1.csproj", opts);
            var result = engine.Compile();

            if (result.HasError)
            {
                foreach (var e in result.Errors)
                    Console.WriteLine(e.Message);
            }

            Assert.IsFalse(result.HasError);
        }

        [Test]
        public void TestClassDefine()
        {
            string f = "ClassDefine.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestMethodLamdaDeclare()
        {
            string f = "NormalClass1.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestAutoProperty()
        {
            string f = "NormalClass2.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestAnonymousObjectJson()
        {
            string f = "JsonAnonymousObject.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestObjectInitalizerJson()
        {
            string f = "JsonObjectInitializer.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestSpecialName()
        {
            string f = "SpecialName.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestStaticClass()
        {
            string f = "StaticClass.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestStaticMember()
        {
            string f = "StaticMemberClass.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestClassImplement()
        {
            string f = "ClassImplement.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestConstEval()
        {
            string f = "ConstEval.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestNormalClass()
        {
            string f = "NormalClass3.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestNoCompileField()
        {
            string f = "NormalClass4.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestGlobalVar()
        {
            string f = "GlobalVar.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestLoop()
        {
            string f = "Loop.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestSwitch()
        {
            string f = "Switch.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestIfElse()
        {
            string f = "IfElse.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestOperators()
        {
            string f = "Operators.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestTryCatch()
        {
            string f = "TryCatch.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestDelegateAndLambda()
        {
            string f = "Lambda.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }

        [Test]
        public void TestNativeJs()
        {
            string f = "Native.js";
            string toCompare = File.ReadAllText(Path.Combine(_jsPath, f)).Trim();
            string generate = File.ReadAllText(Path.Combine(_outPath, f)).Trim();
            Assert.AreEqual(toCompare, generate);
        }
    }
}
