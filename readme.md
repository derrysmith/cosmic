# cosmic

## cosmic-mobile

<!-- badges -->
![build and deploy cosmic mobile app](https://github.com/derrysmith/cosmic/workflows/cosmic-mobile/badge.svg)

### continuous integration/delivery

- create feature branch
	- `git checkout -b issues/123`
- develop on feature branch, commit often
	- `git add -A`
	- `git commit -m "commit message"`
	- `git rebase -i` to cleanup and squash local commits
- push local commits to repository
	- `git push -u origin issues/123`
- open a pull request to merge feature branch into master branch
- on pull request commits
	- build Dockerfile
		- `docker build ...`
	- push docker image to packages repository

on builds, version = 1.0.[pr#]-[run_id]
on merges, version = 1.0.[pr#]

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