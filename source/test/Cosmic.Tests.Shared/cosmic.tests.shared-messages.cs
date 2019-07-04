namespace Cosmic.Tests.Shared.Messages
{
	using Cosmic.Shared.Messages;

	using FakeItEasy;
	using Xunit;
	using Xunit.Extensions;

	public class MessageBaseExtensionsTests
	{
	}

	public class RequestBaseExtensionsTests
	{
	}

	public class ResponseBaseExtensionsTests
	{
		[Fact(DisplayName = "response passes failure test when .Status propery is set to ResponseStatus.Failure")]
		[Trait("unit-test", "ResponseBaseExtensions.IsFailure")]
		public void IsFailure_returnsTrue_whenStatusIsFailure()
		{
			// arrange
			var response = A.Fake<ResponseBase>();
			A.CallTo(() => response.Status).Returns(ResponseStatus.Failure);

			// act
			var actual = ResponseBaseExtensions.IsFailure(response);

			// assert
			Assert.True(actual);
		}

		[Fact(DisplayName = "response fails failure test when .Status property is not set to ResponseStatus.Failure")]
		[Trait("unit-test", "ResponseBaseExtensions.IsFailure")]
		public void IsFailure_returnsFalse_whenStatusIsNotFailure()
		{
			// arrange
			var response = A.Fake<ResponseBase>();
			A.CallTo(() => response.Status).Returns(ResponseStatus.Success);

			// act
			var actual = ResponseBaseExtensions.IsFailure(response);

			// assert
			Assert.False(actual);
		}

		[Fact(DisplayName = "response passes success test when .Status property is set to ResponseStatus.Success")]
		[Trait("unit-test", "ResponseBaseExtensions.IsSuccess")]
		public void IsSuccess_returnsTrue_whenStatusIsSuccess()
		{
			// arrange
			var response = A.Fake<ResponseBase>();
			A.CallTo(() => response.Status).Returns(ResponseStatus.Success);

			// act
			var actual = ResponseBaseExtensions.IsSuccess(response);

			// assert
			Assert.True(actual);
		}

		[Fact(DisplayName = "response fails success test when .Status property is not set to ResponseStatus.Success")]
		[Trait("unit-test", "ResponseBaseExtensions.IsSuccess")]
		public void IsSuccess_returnsFalse_whenStatusIsNotSuccess()
		{
			// arrange
			var response = A.Fake<ResponseBase>();
			A.CallTo(() => response.Status).Returns(ResponseStatus.Failure);

			// act
			var actual = ResponseBaseExtensions.IsSuccess(response);

			// assert
			Assert.False(actual);
		}
	}
}