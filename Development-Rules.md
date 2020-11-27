# Development Rules

## Commit Model

=============================

Model:
``{Type} {summary} ({module})``

Obs: module is optional

=============================

### Types

* Create
* Remove
* Fix
* Update

### Commit Example

> Fix Something (#issueNumber)

----------------------------------------

## Code Model

We have rules to build our codes, if you want to contribute you will have to follow these rules.

[Disclaimer Warning](./README.md#disclaimer)

## ! WARN

If your changes depend on new dependencies for the application, it will take a little more time before we accept your change directly in our code so that we can see if it is really useful to the point where we need more weight (adding new dependencies creates more weight for the project), I hope you understand, thank you!

## Workspace Configuration

Make sure you have this things:

* [NodeJS](https://nodejs.org) installed in your Machine (Recommended: LTS version)
* **MongoDB Server** installed in your Machine
* Optional:
  * [Eslint extension](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint) installed in your Visual Studio Code and allow it to check everything (to facilitate coding)

## How to Start coding

* Clone this repository
* Install the dependencies
  * With NPM = ``npm install``
  * With Yarn = ``yarn``
* *Code your alterations and implementions!*
* Run the system using the "start script" configured in package.json and test your alterations (any other attempt to start the project otherwise will not work)

## How to know if your changes will be approved by our team

* Run the 'lint' script using 'npm run lint' in your favorite shell
* Run the 'build' script using 'npm run build' in your favorite shell
* *if there were no mistakes, you passed!*

----------------------------------------

## Versioning model (For Github Tags)

=============================

Model:
``{Project}-v{Major}.{Minor}.{Patch}-{State}``

=============================

I used several bases that I researched, but the main one that I used was the semantic versioning, which you can learn [here](https://semver.org/)

### Projects

* Game
* Bot
* Website
* RichPresense

### States (In order of "growth")

* indev
* pre-alpha
* alpha
* pre-beta
* beta
* pre-delta
* delta
* stable

### Versions Example

* Game-v1.2.3-stable
* Bot-v1.4.0-pre-beta
* Website-v2.0.0-indev

----------------------------------------

### Navigation menu

* [Main Menu](./README.md)

>     Copyright © 2020 KuryKat
