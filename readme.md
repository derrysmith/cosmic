# cosmic

## cosmic applications

### cosmic-mobile

<!-- badges -->
![build and deploy cosmic mobile app](https://github.com/derrysmith/cosmic/workflows/cosmic-mobile/badge.svg)

## cosmic source code
```
+-- https://github.com/derrysmith/cosmic
	+-- .github
		+-- workflows
			|-- cosmic-mobile.yml
			|-- cosmic-portal.yml
			|-- cosmic-server.yml
			|-- cosmic-webapp.yml
	+-- cosmic-mobile
		|-- Dockerfile
	+-- cosmic-portal
		|-- Dockerfile
	+-- cosmic-server
		+-- src
			+-- firebase
				+-- firestore
				+-- functions
					|-- package.json
				+-- pubsub
				+-- storage
				|-- .firebaserc
				|-- firebase.json
			+-- packages
		|-- Dockerfile
	+-- cosmic-webapp
		|-- Dockerfile
	|-- .gitattributes
	|-- .gitignore
	|-- readme.md
```

## cosmic packages

```
+-- https://github.com/derrysmith/cosmic/packages
	+-- cosmic-mobile
		|-- latest
		|-- 1.0.{pr-number}
		|-- 1.0.{pr-number}-{build-number}
	+-- cosmic-portal
		|-- latest
	+-- cosmic-webapp
		|-- latest
```