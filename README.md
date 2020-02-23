# Nortel BCM
Support tools to help fix/maintain the Nortel Business Communication Manager (BCM).

The BCM is small-to-medium-sized business PBX, originally manufactured by Northern Telecom (Nortel).  A few years ago Nortel went out of business and was taken over by Avaya.  Avaya took over the entire Nortel portfolio which included the BCM range. 

As with all technology, the BCM has now become obsolete, at least for business use.   Avaya has also stopped supporting these units and many people/business are stuck with hardware they can no longer maintain.  Companies are moving to IP-based systems and as a result, BCMs are now being sold on online auctions or worse, being thrown out into landfills as e-waste.  

For telephone enthusiasts like myself who happen to have these units at home, there is, at the moment, no chance of being able to maintain them.  If a board fails, it's game over.   The reason for this is simple:  parts (such as hard drives and main boards) are not interchangeable because each unit is programmed with a unique "System ID" and any change, hardware or software, must be authenticated with a keycode signature.  

Since there is no more support for these units, obtaining keycode signatures is now impossible.  These codes are also required when you want to make a change to your unit, for example, if you want to add more voicemail boxes or increase the number of extensions from 4 to 8, for example.

This repo is aimed at 2 things, creating a password of the day utility and a keycode signature utility.  Both of these are descrbed below.

**Password of the Day**
The Password of the Day (POTD) comes in handy if you ever forget the password to your BCM.  The usual login process involves a username (typically nnadmin) and a password.  Whilst there is one procedure which can be used to reset a system, it usually results in deleting all programming and resetting the unit to factory defaults which is not great.

The POTD was a way for Nortel to allow users to log in to their units using a temporary password along with the login "nnsupport".  Once logged in, the user can then change their password and regain normal access.

In order to generate a POTD, 3 things are required:
1. The unit's System ID (which is the same as its LAN MAC)
2. The current time/date which can be viewed from any connected telephone set
3. The challenge phrase which is stored on the unit - these are normally not changed by users and were set to "trust no one" by default.

Using these three pieces of information, along with static phrases, concatenation and hashing, a POTD can be generated.

* *I am working on getting some initial code out soon for testing so please stay tuned! * *


**Keycode Signature**
The Keycode Signature is ...
