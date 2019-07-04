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

	
}