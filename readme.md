# cosmic

## cosmic-mobile

<!-- badges -->
![build and deploy cosmic mobile app](https://github.com/derrysmith/cosmic/workflows/build%20and%20deploy%20cosmic%20mobile%20app/badge.svg)

## cosmic @ github

on commit (feature branch):

- only build Dockerfile(s) in commit or `docker-compose build` to build all
- deploy containers to container repository (gcr or docker hub)

on commit (master branch):

- `docker-compose build`
- deploy containers to container repository (gcr or docker hub)
- install containers on container hosting (gcr or aws)

```
+-- derrysmith/cosmic
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
		|-- Dockerfile
	+-- cosmic-webapp
		|-- Dockerfile
	|-- .gitattributes
	|-- .gitignore
	|-- docker-compose.yml
		|-- docker-compose.circle.yml
		|-- docker-compose.github.yml
		|-- docker-compose.travis.yml
```

## cosmic @ docker

```
+-- derrysmith/cosmic-mobile
	|-- latest-android
	|-- latest-ios
+-- derrysmith/cosmic-portal
	|-- latest
	|-- 1.2.34
+-- derrysmith/cosmic-webapp
	|-- latest
	|-- 1.2.34
```