using System;
using System.Runtime.CompilerServices;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace HugeInt
{
    public static class HugeIntBase
    {
        static readonly ScriptEngine engine = Python.CreateEngine();
        static readonly ScriptScope scope = engine.CreateScope();

        public static dynamic Sum(String numberOne, String numberTwo)
        {
            String code = $"x = {numberOne} + {numberTwo}";
            engine.Execute(code, scope);
            return scope.GetVariable("x");
        }

        public static dynamic Diff(String numberOne, String numberTwo)
        {
            String code = $"x = {numberOne} - {numberTwo}";
            engine.Execute(code, scope);
            return scope.GetVariable("x");
        }

        public static dynamic Multiplication(String numberOne, String numberTwo)
        {
            String code = $"x = {numberOne} * {numberTwo}";
            engine.Execute(code, scope);
            return scope.GetVariable("x");
        }

        public static dynamic Division(String numberOne, String numberTwo)
        {
            String code = $"x = {numberOne} / {numberTwo}";
            engine.Execute(code, scope);
            return scope.GetVariable("x");
        }
    }
}
