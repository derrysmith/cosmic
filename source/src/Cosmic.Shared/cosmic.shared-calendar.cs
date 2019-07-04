namespace Cosmic.Shared.Calendar.Entities
{
	public interface IEvent
	{
		string ID { get; }

		string DisplayName { get; }
		string Description { get; }

		// for one-time events
		string Date { get; }

		// for recurring events
		string Cron { get; }

		// duration (instead of start/end datetimes, just calculate the length of the event)
		long? DurationInSeconds { get; }
	}

	// my birthday: 4/30/1975, every year
	// event: { "id": "1", "displayName": "my birthday", "date": "1975-04-30T00:00:00", "cron": "0 0 0 30 4 ? *", "duration": null }

	// dmv appointment: 7/5/2019 @ 8:30 AM, lasts for 1 hour
	// event: { "id": "2", "displayName": "dmv appointment", "date": "2019-07-05T08:30:00", "cron": null, "duration": 3600 }
}