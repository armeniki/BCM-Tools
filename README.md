# BCM Tools
Support tools to help fix/maintain the Nortel Business Communication Manager (BCM).

The BCM is small-to-medium size PBX, originally manufactured by Northern Telecom (Nortel).  A few years ago Nortel went out of business and was then taken over by Avaya, which took over the entire Nortel portfolio and included the BCM range.  

As with all technology, the BCM is now obsolete and end-of-life.  Avaya has stopped supporting these units and many people are stuck with hardware they can no longer maintain.  Companies have now moved on to IP-based/cloud systems and as a result, BCMs are being decommissioned everywhere, sold on online auctions or worse, thrown out into landfills as e-waste.  

For telephone collectors or enthusiasts like myself who happen to have these units at home, there is, at the moment, very little ability to maintain them.  The parts for the BCM (such as hard drives and main boards) are not easily interchangeable because each unit is programmed with a unique "System ID".  Any change, whether it's hardware or software, must be authenticated with a new keycode signature.  Since there is no more support for these units, obtaining a keycode signature through Nortel or Avaya is now impossible.

The purpose of this project is to help maintain and repair your unit by providing some tools.  Some are completed, some are in progress.


## Password of the Day - completed & available
The Password of the Day (POTD) comes in handy if you ever forget the password to your BCM.  The usual login process involves a username (typically "nnadmin") and a password.  Whilst there is a procedure which can be used to reset a system, it usually results in deleting all of its programming and resetting the unit to factory defaults which is not great.

The POTD was originally designed to allow support personnel to log in to these units using a temporary password to change the admin password to regain normal access.


## Licence File Generator - in progress
*This project is in progress and incomplete.*

This is a simple application which will present the user with all of the features or options that can be modified on the BCM.  Once all of the desired options are selected, the user can then generate a .lic file which is then uploaded to the BCM via Element Manager.

However, there are other ways of modifying available features and performing upgrades on the BCM.  This involves patching a particular file in various locations of its binary.  So I can not give too much priority to this particular project.


## Custom Date Formatting
The BCM is a very powerful communications platform but unfortunately, it is not very customisable in some ways.  The built-in profiles come with preselected language options.  These language options may or may not reflect what the user actually wants.

I have had requests to customise the Canada profile and have provided the necessary patching info on this page.  I'll post some more modification patches if people request them.


## Custom Tones
Similar to the above, these patches will allow for custom tones to be programmed.


### Want to help with these project?
If you're interested in telephones and have some programming experience, please get in touch.  Any assistance would be appreciated!

If you'd like to upload any files to assist with this project, please use the following Dropbox link.  You do not need to have a Dropbox account to use it, simply click on the "Choose Files" button.

https://www.dropbox.com/request/uYwWzCAZVK7fZ3PuEgoc

