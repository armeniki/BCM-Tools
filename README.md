# BCM Tools
Support tools to help fix/maintain the Nortel Business Communication Manager (BCM).

The BCM is small-to-medium size PBX, originally manufactured by Northern Telecom (Nortel).  A few years ago Nortel went out of business and was then taken over by Avaya, which took over the entire Nortel portfolio and included the BCM range.  

As with all technology, the BCM is now obsolete and end-of-life.  Avaya has stopped supporting these units and many people are stuck with hardware they can no longer maintain.  Companies have now moved on to IP-based/cloud systems and as a result, BCMs are being decommissioned everywhere, sold on online auctions or worse, thrown out into landfills as e-waste.  

For telephone collectors or enthusiasts like myself who happen to have these units at home, there is, at the moment, very little ability to maintain them.  The parts for the BCM (such as hard drives and main boards) are not easily interchangeable because each unit is programmed with a unique "System ID".  Any change, whether it's hardware or software, must be authenticated with a new keycode signature.  Since there is no more support for these units, obtaining a keycode signature through Nortel or Avaya is now impossible.

The purpose of this project is to help maintain and repair your unit by providing a couple of tools:

## Password of the Day
The Password of the Day (POTD) comes in handy if you ever forget the password to your BCM.  The usual login process involves a username (typically "nnadmin") and a password.  Whilst there is a procedure which can be used to reset a system, it usually results in deleting all of its programming and resetting the unit to factory defaults which is not great.

The POTD was originally designed to allow support personnel to log in to these units using a temporary password to change the admin password to regain normal access.



## Keycode Signature
*Please note, this project is in progress and incomplete.*

The keycode signature is required when making hardware or software changes to the unit, through Element Manager, its graphical user interface.

For example, if you wanted to increase the number of extensions your unit provides from 8 to 12, you would need to make those changes within Element Manager but would also need to update the unit's keycode signature to reflect that change. 

### Want to help with this project?
If you're interested in telephones and have some programming experience, please get in touch.  We'd welcome your help!

