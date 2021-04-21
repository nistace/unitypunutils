using System;
using System.Collections.Generic;
using Utils.Extensions;
using Utils.Pun.Random;

namespace Utils.Pun.Extensions {
	public static class EnumerableExtension {
		public static E NetworkRandom<E>(this IEnumerable<E> array) => array.Random(PunRandom.Range);
		public static E NetworkRandom<E>(this IList<E> array, Func<E, float> probability) => array.Random(1, probability, PunRandom.Range).GetSafe(0);
		public static E[] NetworkRandom<E>(this IList<E> array, int size, Func<E, float> probability) => array.Random(size, probability, PunRandom.Range);
	}
}