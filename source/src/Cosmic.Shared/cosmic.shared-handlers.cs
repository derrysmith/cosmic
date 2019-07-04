namespace Cosmic.Shared.Handlers
{
	using System.Threading;
	using System.Threading.Tasks;

	public interface IAsyncHandler<in T>
	{
		Task HandleAsync(T message, CancellationToken token = default);
	}

	public interface IAsyncHandler<in T, U>
	{
		Task<U> HandleAsync(T message, CancellationToken token = default);
	}

	public interface IAsyncHandlerFactory
	{
		IAsyncHandler<T, U> GetAsyncHandler<T, U>();
	}
}