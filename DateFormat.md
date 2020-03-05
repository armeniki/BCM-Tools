# Date Format Patching
In order for these patches to work, you will require "root" access to the BCM.

The file which needs to be updated is called **CoreTel** and is located in **/nn/sbin**.

## Canada
### English - day month patch
This patch changes the default dislpay date format from Month Day (June 5) to Day Month (5 June)
https://github.com/armeniki/BCM-Tools/blob/master/dateformat/patches/Canada_ddmm_en.md

### French - day month patch
This patch changes the default dislpay date format from ISO (YYYY-MM-DD) to the standard French (21 juin)
https://github.com/armeniki/BCM-Tools/blob/master/dateformat/patches/Canada_ddmm_fr.md
