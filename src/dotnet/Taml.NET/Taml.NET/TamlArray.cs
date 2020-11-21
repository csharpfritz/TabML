using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TAML
{

	/// <summary>
	/// Represents a collection of values in a TAML document
	/// </summary>
	public class TamlArray : TamlValue, IEnumerable<TamlValue>
	{

		private readonly List<TamlValue> _Values = new List<TamlValue>();

		/// <summary>
		/// Access a value in the array by position
		/// </summary>
		/// <value>An entry in the array</value>
		public TamlValue this[int pos]
		{
			get { return _Values.Skip(pos).First(); }
		}

		public IEnumerator<TamlValue> GetEnumerator()
		{
			return ((IEnumerable<TamlValue>)_Values).GetEnumerator();
		}

		internal void AppendValue(TamlValue newValue)
		{
			_Values.Add(newValue);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)_Values).GetEnumerator();
		}

		public override string ToString()
		{
			return string.Join(",", _Values);
		}

	}

}
