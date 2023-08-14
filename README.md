# APS-PKCE-DESKTOP-APP

![Platforms](https://img.shields.io/badge/platform-Windows|MacOS-lightgray.svg)
![.NET](https://img.shields.io/badge/.NET%20Core-3.1-blue.svg)
[![License](http://img.shields.io/:license-MIT-blue.svg)](http://opensource.org/licenses/MIT)

[![oAuth2](https://img.shields.io/badge/oAuth2-v1-green.svg)](http://developer.autodesk.com/)

## Introduction

This sample demonstrates a quick workflow to generate a three legged token from a desktop app using [3-Legged Token with Authorization Code Grant (PKCE)](https://aps.autodesk.com/en/docs/oauth/v2/tutorials/get-3-legged-token-pkce/)

## How it works

The token is retrieved at the windows form app, using the UI below:

![formui](./assets/form.png)
Where:

1 – Clicking on generate token triggers the process

2 – Once it’s done, token will be posted in the texbox

I uses the workflow below to obtain the token

![diagram](./assets/workflow.png)

Where:

1 – user access the Desktop app

2 – app redirects the user to authorization server

3 – after logging in and allowing access, authorization server sends credential code to call-back url and this request is intercepted by the desktop app.

4 – Desktop app sends credential code with code verifier to Exchange it for a token

5 – Oauth API returns the token (including refresh token) to desktop app

# Setup

## Prerequisites

1. **APS Account**: Learn how to create a APS Account, activate subscription and create an app at [this tutorial](http://aps.autodesk.com/tutorials/#/account/).
2. **Visual Studio**: Community or Pro.
3. **.NET** basic knowledge with C#

## Running locally

Clone this project or download it. It's recommended to install [GitHub desktop](https://desktop.github.com/). To clone it via command line, use the following (**Terminal** on MacOSX/Linux, **Git Shell** on Windows):

    git clone https://github.com/autodesk-platform-services/aps-pkce-desktop-app

**Visual Studio** (Windows):

Go to properties folder and then double-click on resources and change **client id** and **callback url** with your own.

# Further Reading

### Troubleshooting

1. **Not being redirected**: Make sure to add your callback url to your aps app.

2. **Not retrieving the token**: Make sure you've provided the proper callback to httplistener 

3. **Not able to read ACC/BIM 360 data with acquired token**: Make sure to provision the APS App Client ID within the BIM 360 Account, [learn more here](https://aps.autodesk.com/blog/bim-360-docs-provisioning-forge-apps). This requires the Account Admin permission.

## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT). Please see the [LICENSE](LICENSE) file for full details.

## Written by

João Martins [@JooPaulodeOrne2](http://twitter.com/JooPaulodeOrne2), [APS Partner Development](http://aps.autodesk.com)
