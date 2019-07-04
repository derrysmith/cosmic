namespace Cosmic.Shared.Contacts.Entities
{
	public interface IContact
	{
		string ID { get; }

		string FName { get; }
		string MName { get; }
		string LName { get; }
		string Alias { get; }

		string Prefix { get; }
		string Suffix { get; }
	}
}

namespace Cosmic.Shared.Contacts.Messages
{
	using Cosmic.Shared.Contacts.Entities;

	using Cosmic.Shared.Messages;

	using System.Collections.Generic;
	using System.Collections.Specialized;

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