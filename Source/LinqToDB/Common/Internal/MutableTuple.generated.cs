﻿// <auto-generated> This file has been auto generated. </auto-generated>
//#nullable enable
using System;
using System.Collections.Generic;

namespace LinqToDB.Common.Internal
{
	internal static partial class MutableTuple
	{
		public const int MaxMemberCount = 10;

		public static readonly Type[] MTypes = new []
		{
			typeof(MTuple<>),
			typeof(MTuple<,>),
			typeof(MTuple<,,>),
			typeof(MTuple<,,,>),
			typeof(MTuple<,,,,>),
			typeof(MTuple<,,,,,>),
			typeof(MTuple<,,,,,,>),
			typeof(MTuple<,,,,,,,>),
			typeof(MTuple<,,,,,,,,>),
			typeof(MTuple<,,,,,,,,,>),
		};

		internal static int CombineHashCodes(int h1, int h2)
		{
			return (((h1 << 5) + h1) ^ h2);
		}
		internal static int CombineHashCodes(int h1, int h2, int h3)
			=> CombineHashCodes(CombineHashCodes(h1, h2), h3);

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
			=> CombineHashCodes(CombineHashCodes(h1, h2), CombineHashCodes(h3, h4));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3), CombineHashCodes(h4, h5));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3), CombineHashCodes(h4, h5, h6));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3, h4), CombineHashCodes(h5, h6, h7, h8));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8, int h9)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3, h4, h5), CombineHashCodes(h6, h7, h8, h9));

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8, int h9, int h10)
			=> CombineHashCodes(CombineHashCodes(h1, h2, h3, h4, h5), CombineHashCodes(h6, h7, h8, h9, h10));

	}

	internal class MTuple<T1>
	{
		public T1 Item1 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1);
		}

		public override int GetHashCode()
			=> _item1ValueComparer.GetHashCode(Item1);
	}
	internal class MTuple<T1, T2>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2));
	}
	internal class MTuple<T1, T2, T3>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3));
	}
	internal class MTuple<T1, T2, T3, T4>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4));
	}
	internal class MTuple<T1, T2, T3, T4, T5>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5));
	}
	internal class MTuple<T1, T2, T3, T4, T5, T6>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		static IEqualityComparer<T6> _item6ValueComparer = ValueComparer.GetDefaultValueComparer<T6>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5, T6>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5)
				&& _item6ValueComparer.Equals(Item6, objTuple.Item6);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5),
				_item6ValueComparer.GetHashCode(Item6));
	}
	internal class MTuple<T1, T2, T3, T4, T5, T6, T7>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		static IEqualityComparer<T6> _item6ValueComparer = ValueComparer.GetDefaultValueComparer<T6>(true);
		static IEqualityComparer<T7> _item7ValueComparer = ValueComparer.GetDefaultValueComparer<T7>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5)
				&& _item6ValueComparer.Equals(Item6, objTuple.Item6)
				&& _item7ValueComparer.Equals(Item7, objTuple.Item7);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5),
				_item6ValueComparer.GetHashCode(Item6),
				_item7ValueComparer.GetHashCode(Item7));
	}
	internal class MTuple<T1, T2, T3, T4, T5, T6, T7, T8>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		static IEqualityComparer<T6> _item6ValueComparer = ValueComparer.GetDefaultValueComparer<T6>(true);
		static IEqualityComparer<T7> _item7ValueComparer = ValueComparer.GetDefaultValueComparer<T7>(true);
		static IEqualityComparer<T8> _item8ValueComparer = ValueComparer.GetDefaultValueComparer<T8>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7, T8>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5)
				&& _item6ValueComparer.Equals(Item6, objTuple.Item6)
				&& _item7ValueComparer.Equals(Item7, objTuple.Item7)
				&& _item8ValueComparer.Equals(Item8, objTuple.Item8);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5),
				_item6ValueComparer.GetHashCode(Item6),
				_item7ValueComparer.GetHashCode(Item7),
				_item8ValueComparer.GetHashCode(Item8));
	}
	internal class MTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		static IEqualityComparer<T6> _item6ValueComparer = ValueComparer.GetDefaultValueComparer<T6>(true);
		static IEqualityComparer<T7> _item7ValueComparer = ValueComparer.GetDefaultValueComparer<T7>(true);
		static IEqualityComparer<T8> _item8ValueComparer = ValueComparer.GetDefaultValueComparer<T8>(true);
		static IEqualityComparer<T9> _item9ValueComparer = ValueComparer.GetDefaultValueComparer<T9>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5)
				&& _item6ValueComparer.Equals(Item6, objTuple.Item6)
				&& _item7ValueComparer.Equals(Item7, objTuple.Item7)
				&& _item8ValueComparer.Equals(Item8, objTuple.Item8)
				&& _item9ValueComparer.Equals(Item9, objTuple.Item9);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5),
				_item6ValueComparer.GetHashCode(Item6),
				_item7ValueComparer.GetHashCode(Item7),
				_item8ValueComparer.GetHashCode(Item8),
				_item9ValueComparer.GetHashCode(Item9));
	}
	internal class MTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		static IEqualityComparer<T1> _item1ValueComparer = ValueComparer.GetDefaultValueComparer<T1>(true);
		static IEqualityComparer<T2> _item2ValueComparer = ValueComparer.GetDefaultValueComparer<T2>(true);
		static IEqualityComparer<T3> _item3ValueComparer = ValueComparer.GetDefaultValueComparer<T3>(true);
		static IEqualityComparer<T4> _item4ValueComparer = ValueComparer.GetDefaultValueComparer<T4>(true);
		static IEqualityComparer<T5> _item5ValueComparer = ValueComparer.GetDefaultValueComparer<T5>(true);
		static IEqualityComparer<T6> _item6ValueComparer = ValueComparer.GetDefaultValueComparer<T6>(true);
		static IEqualityComparer<T7> _item7ValueComparer = ValueComparer.GetDefaultValueComparer<T7>(true);
		static IEqualityComparer<T8> _item8ValueComparer = ValueComparer.GetDefaultValueComparer<T8>(true);
		static IEqualityComparer<T9> _item9ValueComparer = ValueComparer.GetDefaultValueComparer<T9>(true);
		static IEqualityComparer<T10> _item10ValueComparer = ValueComparer.GetDefaultValueComparer<T10>(true);
		public override bool Equals(object other)
		{
			if (other == null) return false;

			var objTuple = other as MTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;

			if (objTuple == null)
				return false;

			return _item1ValueComparer.Equals(Item1, objTuple.Item1)
				&& _item2ValueComparer.Equals(Item2, objTuple.Item2)
				&& _item3ValueComparer.Equals(Item3, objTuple.Item3)
				&& _item4ValueComparer.Equals(Item4, objTuple.Item4)
				&& _item5ValueComparer.Equals(Item5, objTuple.Item5)
				&& _item6ValueComparer.Equals(Item6, objTuple.Item6)
				&& _item7ValueComparer.Equals(Item7, objTuple.Item7)
				&& _item8ValueComparer.Equals(Item8, objTuple.Item8)
				&& _item9ValueComparer.Equals(Item9, objTuple.Item9)
				&& _item10ValueComparer.Equals(Item10, objTuple.Item10);
		}

		public override int GetHashCode()
			=> MutableTuple.CombineHashCodes(_item1ValueComparer.GetHashCode(Item1),
				_item2ValueComparer.GetHashCode(Item2),
				_item3ValueComparer.GetHashCode(Item3),
				_item4ValueComparer.GetHashCode(Item4),
				_item5ValueComparer.GetHashCode(Item5),
				_item6ValueComparer.GetHashCode(Item6),
				_item7ValueComparer.GetHashCode(Item7),
				_item8ValueComparer.GetHashCode(Item8),
				_item9ValueComparer.GetHashCode(Item9),
				_item10ValueComparer.GetHashCode(Item10));
	}
}
