using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Produire.Interop
{
	[種類("ニシキヘビ")]
	public class PythonInterop : IProduireStaticClass
	{
		Microsoft.Scripting.Hosting.ScriptEngine _engine;
		ScriptScope _scope;

		public PythonInterop()
		{
			_engine = Python.CreateEngine();
			_scope = _engine.CreateScope();
		}

		[自分("に"), 手順("食わせる")]
		public object Execute([を]string code)
		{
			var result = _engine.Execute(code, _scope);
			return result;
		}

		[自分("へ"), 手順("設定")]
		public void SetVariable([として] string name, [を] object value)
		{
			_scope.SetVariable(name, value);
		}
	}
}
