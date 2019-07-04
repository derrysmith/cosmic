//namespace System.Collections.Generic
//{
//	using System.Linq;

//	public interface IPage
//	{
//		int CurrentPageIndex { get; }
//		int CurrentPageSize { get; }

//		bool HasNextPage { get; }
//		bool HasPrevPage { get; }

//		int TotalItems { get; }
//		int TotalPages { get; }
//	}

//	public interface IPage<T> : IPage, IReadOnlyList<T>
//	{
//	}

//	public class Page<T> : IPage<T>
//	{
//		readonly List<T> _items = new List<T>();

//		private Page(int pi, int ps, int total)
//		{
//			if (pi < 0)
//				throw new System.ArgumentOutOfRangeException(nameof(pi));
//			if (ps <= 0)
//				throw new System.ArgumentOutOfRangeException(nameof(ps));
//			if (total < 0)
//				throw new System.ArgumentOutOfRangeException(nameof(total));

//			this.CurrentPageIndex = pi;
//			this.CurrentPageSize = ps;

//			this.TotalItems = total;
//			this.TotalPages = this.TotalItems > 0
//				? (int)System.Math.Ceiling(this.TotalItems / (double)this.CurrentPageSize) : 0;

//			this.HasPrevPage = this.CurrentPageIndex > 0;
//			this.HasNextPage = this.CurrentPageIndex < this.TotalPages - 1;
//		}

//		public Page(IEnumerable<T> source, int pi, int ps)
//			: this(pi, ps, source?.Count() ?? 0)
//		{
//			if (this.TotalItems > 0)
//			{
//				_items.AddRange(this.CurrentPageIndex == 0
//					? source.Take(this.CurrentPageSize)
//					: source.Skip(this.CurrentPageIndex * this.CurrentPageSize).Take(this.CurrentPageSize)
//				);
//			}
//		}

//		public Page(IEnumerable<T> subset, int pi, int ps, int total)
//			: this(pi, ps, total)
//		{
//			if (this.TotalItems > 0)
//				_items.AddRange(subset);
//		}

//		public IEnumerator<T> GetEnumerator()
//		{
//			return _items.GetEnumerator();
//		}

//		IEnumerator IEnumerable.GetEnumerator()
//		{
//			return this.GetEnumerator();
//		}

//		public T this[int index]
//		{
//			get { return _items[index]; }
//		}

//		public int CurrentPageIndex { get; private set; }
//		public int CurrentPageSize { get; private set; }

//		public bool HasNextPage { get; private set; }
//		public bool HasPrevPage { get; private set; }

//		public int TotalItems { get; private set; }
//		public int TotalPages { get; private set; }

//		public int Count
//		{
//			get { return _items.Count; }
//		}
//	}
//}

namespace Cosmic.Shared.Messages
{
	using System.Runtime.Serialization;

	[DataContract]
	public abstract class MessageBase
	{
		[DataMember(Name = "_mid")]
		public virtual string MessageID { get; set; }

		[DataMember(Name = "_pid")]
		public virtual string ProcessID { get; set; }
	}

	public static class MessageBaseExtensions
	{
	}

	[DataContract]
	public abstract class RequestBase : MessageBase
	{
	}

	public static class RequestBaseExtensions
	{
	}

	[DataContract]
	public abstract class ResponseBase : MessageBase
	{
		public virtual ResponseStatus Status { get; set; }
	}

	public static class ResponseBaseExtensions
	{
		public static bool IsFailure<R>(this R response) where R : ResponseBase
		{
			return response.Status != ResponseStatus.Success;
		}

		public static bool IsSuccess<R>(this R response) where R : ResponseBase
		{
			return response.Status == ResponseStatus.Success;
		}
	}

	public enum ResponseStatus
	{
		Failure = 0,
		Success = 1
	}
}