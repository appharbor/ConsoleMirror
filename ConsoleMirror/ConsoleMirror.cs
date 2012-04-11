using System;
using System.IO;
using System.Text;

namespace AppHarbor
{
	public class ConsoleMirror : StringWriter
	{
		static ConsoleMirror _instance;
		public static void Initialize()
		{
			_instance = new ConsoleMirror(Console.Out);
			Console.SetOut(_instance);
		}

		public static string Captured
		{
			get
			{
				return _instance.ToString();
			}
		}


		TextWriter _original;

		public ConsoleMirror(TextWriter original)
			: base(new StringBuilder())
		{
			_original = original;
		}

		public StringBuilder Buffer
		{
			get { return base.GetStringBuilder(); }
		}

		public override void Write(char value)
		{
			_original.Write(value);
			base.Write(value);
		}

		public override void Write(string value)
		{
			_original.Write(value);
			base.Write(value);
		}

		public override void Write(char[] buffer, int index, int count)
		{
			_original.Write(buffer, index, count);
			base.Write(buffer, index, count);
		}
	}
}
