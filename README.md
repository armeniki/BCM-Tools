# Nortel BCM Tools
Support tools to help fix/maintain the Nortel Business Communication Manager (BCM).

The BCM is small-to-medium-sized business PBX, originally manufactured by Northern Telecom (Nortel).  A few years ago Nortel went out of business and was taken over by Avaya.  Avaya took over the entire Nortel portfolio which included the BCM range.  If you are here, you probably are already ware of what the BCM is and how it works, so I am not going into that much detail.

As with all technology, the BCM has now become obsolete, at least for business use.   Avaya has also stopped supporting these units and many people/business are stuck with hardware they can no longer maintain.  Companies are moving to IP-based systems and as a result, BCMs are now being sold on online auctions or worse, being thrown out into landfills as e-waste.  

For telephone enthusiasts like myself who happen to have these units at home, there is, at the moment, no chance of being able to maintain them.  If a board fails, it's game over.   The reason for this is simple:  parts (such as hard drives and main boards) are not interchangeable because each unit is programmed with a unique "System ID" and any change, hardware or software, must be authenticated with a keycode signature.  

Since there is no more support for these units, obtaining keycode signatures is now impossible.  These codes are also required when you want to make a change to your unit, for example, if you want to add more voicemail boxes or increase the number of extensions from 4 to 8, for example.

This repo is aimed at 2 things, creating a password of the day (POTD) utility and a keycode signature utility.  Both of these are descrbed below.

**Password of the Day**
The Password of the Day (POTD) comes in handy if you ever forget the password to your BCM.  The usual login process involves a username (typically nnadmin) and a password.  Whilst there is one procedure which can be used to reset a system, it usually results in deleting all programming and resetting the unit to factory defaults which is not great.

The POTD was a way for Nortel to allow users to log in to their units using a temporary password along with the login "nnsupport".  Once logged in, the user can then change their password and regain normal access.

In order to generate a POTD, 3 things are required:
1. The unit's System ID (which is the same as its LAN MAC)
2. The current time/date which can be viewed from any connected telephone set
3. The challenge phrase which is stored on the unit - these are normally not changed by users and were set to "trust no one" by default.

Using these three pieces of information, along with static phrases, concatenation and hashing, a POTD can be generated.

*I am working on getting some initial code out soon for testing so please stay tuned! * 


**Keycode Signature**
The keycode signature is required when making hardware or software changes to the BCM, via its user interface which is called Element Manager.  

For example, if you wanted to increase the number of extensions your unit provides from 8 to 12, you would need to make those changes within Element Manager but would also need to update the unit's keycode signature to reflect that change.  

Nortel manufactured different "releases" of this units: R1 to R6.  For units that are R1, R2 and R3, keycode signature generation is again fairly straightforward, using hashing and concatenation simlilar to the POTD method.  However, for releases R5 and R6, Nortel decided to change to a PKI (public key infrastructure) style, which requires a bit more work.


