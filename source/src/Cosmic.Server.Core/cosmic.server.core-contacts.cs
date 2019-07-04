namespace Cosmic.Server.Contacts.Entities
{
	using Cosmic.Shared.Contacts.Entities;

	public class Contact : IContact
	{
		public virtual string ID { get; set; }

		public virtual string FName { get; set; }
		public virtual string MName { get; set; }
		public virtual string LName { get; set; }
		public virtual string Alias { get; set; }

		public virtual string Prefix { get; set; }
		public virtual string Suffix { get; set; }
	}
}

namespace Cosmic.Server.Contacts.Messages
{
	using Cosmic.Shared.Contacts.Entities;
	using Cosmic.Shared.Messages;

    using System.Collections.Generic;

    public class GetContactRequest : RequestBase
	{
		public string ContactID { get; set; }
	}

	public class GetContactResponse : ResponseBase
	{
		public IContact Contact { get; set; }
	}

	public class GetContactsByFilterRequest : RequestBase
	{
	}

	public class GetContactsByFilterResponse : ResponseBase
	{
		public IEnumerable<IContact> Contacts { get; set; }
	}

	public class GetContactsBySearchRequest : RequestBase
	{
		public string SearchText { get; set; }
	}

	public class GetContactsBySearchResponse : ResponseBase
	{
		public IEnumerable<IContact> Contacts { get; set; }
	}
}

namespace Cosmic.Server.Contacts.Handlers
{
    using Cosmic.Server.Contacts.Entities;
    using Cosmic.Server.Contacts.Messages;

	using Cosmic.Shared.Handlers;
    using Cosmic.Shared.Messages;

    using System.Threading;
	using System.Threading.Tasks;

	public class ContactRequestHandler
		: IAsyncHandler<GetContactRequest, GetContactResponse>
	{
		public async Task<GetContactResponse> HandleAsync(GetContactRequest message, CancellationToken token = default)
		{
			return new GetContactResponse
			{
				MessageID = "",
				ProcessID = message.ProcessID,
				Contact = new Contact { ID = message.ContactID },
				Status = ResponseStatus.Success
			};
		}
	}
}