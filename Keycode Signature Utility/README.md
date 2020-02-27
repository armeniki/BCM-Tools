# Keycode Signature Utility

## Further project information

### What is cfsserver?
The cfsserver is an executable which is located on the BCM's HDD or SSD.  It is initialised on startup by the usual init.d scripts.

It runs not only as a service but also on-demand via root access during an SSH session.

cfserver has the following command line options:

Usage: cfsserver -[newkey|keygen|sign|verify|run|show|genrec|check|signature|signverify]

One of the functions cfsserver provides is to verify the keycode which is contained within a licence file *(usually named MAC_ID.lic)* that users were previously able to acquire from the manufacturer.  Of course, since the BCMs are no longer supported and considered obsolete, that is not longer possible.

Once the information within the file is parsed, cfsserver runs a few calculations and determines if all of the file's contents are valid.  If so, the file is considered verified.  Once that takes place, the installation or system update can continue.

It should be noted that cfsserver does have multiple duties to perform on the BCM platform, which include certificate generation, signing and so forth.  However, those functions are not related to this project.  

### Command Line Options
The method of verifying a keycode signature through the command line is accomplished as follows:

cfsserver -verify /path_to_file (An example of a file follows)

SystemId: AABBCCDDEEFF
Sequence: 1
KeyType: 2
#' VM seat
202 12
#' Int Digital Sets
117 12
KeyCode:
000000000000000000000000

The file is then parsed, analysed and a message will appear indicating if the file was verified or not, along with an exit status code of 0 or 1, respectively.





 
