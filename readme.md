# cosmic

[![shields-twitter](https://img.shields.io/twitter/follow/derryroshad.svg?style=flat-square)][1]
[![shields-circle](https://img.shields.io/circleci/build/github/derrysmith/cosmic/master.svg?style=flat-square)][6]
[![shields-license](https://img.shields.io/github/license/derrysmith/cosmic.svg?style=flat-square)][2]
[![shields-issues](https://img.shields.io/github/issues-raw/derrysmith/cosmic.svg?style=flat-square)][5]
[![shields-beerpay](https://img.shields.io/beerpay/derrysmith/cosmic.svg?style=flat-square)][3]

Social-Media driven Contact Management System.

## inspiration

> Funkadelic. "Cosmic Slop." _Cosmic Slop_, Westbound Records, 1973.<br />_Spotify_, [open.spotify.com/track/6lc5JOnCJsD0YhYxms7DNw][4]

## getting started

## usage

## contributing

## credits




```
+-- github.com/derrysmith/cosmic
	+-- branches
		|-- master
			|-- issues/001
			|-- issues/002
			|-- issues/003
			|-- hotfix/004
```

```
+-- cosmic
	+-- source
		+-- src
			+-- Cosmic.Shared
				+-- _Entities
				+-- _Messages
				+-- Calendar
				+-- Contacts
			+-- Cosmic.Mobile
			+-- Cosmic.Mobile.Host
			+-- Cosmic.Client
			+-- Cosmic.Client.Host
			
			+-- Cosmic.Syncro - synchronizes external account data with cosmic
			+-- Cosmic.Cronos.Host
				+-- Services
			
			+-- Cosmic.Notify - handles push notifications and emails to clients
			+-- Cosmic.Notify.Core
			+-- Cosmic.Notify.Host
				+-- Services
			
			+-- Cosmic.Server
				+-- Calendar
				+-- Contacts
			+-- Cosmic.Server.Core
				+-- Calendar
				+-- Contacts
			+-- Cosmic.Server.Host
				+-- Services

```

```json
{
	"accounts": {
		"account:c5991dc5f12f480b85de5c81f1d1bdcf": {
			"id": "c5991dc5f12f480b85de5c81f1d1bdcf",
			
			"calendar": {
				"event:e955ff287e69426889c288260a0127c0": {
					"id": "e955ff287e69426889c288260a0127c0"
				},

				"event:202f39e9435f4645bd41781604cb30c5": {
					"id": "202f39e9435f4645bd41781604cb30c5"
				}
			},

			"contacts": {
				"contact:f3ec406b453f4596b3759d21f3a73574": {
					"id": "f3ec406b453f4596b3759d21f3a73574",
					"fname": "",
					"mname": "",
					"lname": "",
					"alias": "",
					"prefix": "",
					"suffix": "",
					"addresses": [],
					"histories": [],
					"emails": [],
					"phones": []
				},

				"contact:791baffd09a049fc8c4a860f23ecfa08": {
					"id": "791baffd09a049fc8c4a860f23ecfa08"
				},

				"contact:17b62df82050488fbe8632ef653c678d": {
					"id": "17b62df82050488fbe8632ef653c678d"
				}
			},
			
			"settings": {
				"calendar.view": "month",
				"calendar.sort": "asc",
				"contacts.sort": "lnamefname asc"
			}
		}
	},

	"contacts": {
		"address-type:home": { "displayName": "Home", "description": "" },
		"address-type:work": { "displayName": "Work", "description": "" },
		"phone-type:home": null,
		"phone-type:work": null,
		"phone-type:cell": null
	},

	"settings": {

	}
}
```

[1]: https://twitter.com/derryroshad
[2]: https://github.com/derrysmith/cosmic/blob/master/license.md
[3]: https://github.com/derrysmith/cosmic
[4]: https://open.spotify.com/track/6lc5JOnCJsD0YhYxms7DNw?si=X9_0wY5bTkq44ZxkQ30bhg
[5]: https://github.com/derrysmith/cosmic
[6]: https://circleci.com/gh/derrysmith/cosmic