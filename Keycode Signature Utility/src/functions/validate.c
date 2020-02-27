
/* CLicense::validate(char*) */

undefined4 __thiscall validate(CLicense *this,char *param_1)

{
  bool bVar1;
  CKeyGen *this_00;
  int iVar2;
  undefined4 uVar3;
  uchar *__s;
  uint uVar4;
  uchar *puVar5;
  int iVar6;
  int *piVar7;
  char in_RESERVE;
  byte bVar8;
  CFile aCStack168 [32];
  int local_88 [4];
  char local_78;
  undefined auStack119 [79];
  uint local_28 [3];
  
  this_00 = (CKeyGen *)instance();
  if ((this_00 == (CKeyGen *)0x0) || (iVar2 = readSecSi(this_00), iVar2 == 0)) {
    LogFile(1,0x794c,s_failed_to_open_license_file__100208cc);
  }
  else {
    if (param_1 == (char *)0x0) {
      param_1 = sLicenseFileName;
    }
    CFile(aCStack168,param_1,0,0);
                    /* try { // try from 10012c88 to 10012d2b has its CatchHandler @ 10012fac */
    iVar2 = isOpen(aCStack168);
    if (iVar2 == 0) {
      LogFile(1,0x794c,s_failed_to_open_license_file_100208ec);
    }
    else {
      uVar3 = getModificationTime(sLicenseFileName);
      *(undefined4 *)(this + 0x34) = uVar3;
      iVar2 = size(aCStack168);
      __s = (uchar *)operator_new__(iVar2 + 1);
      if (__s == (uchar *)0x0) {
        LogFile(1,0x7994,s_failed_to_new_obj_1001e708);
        close(aCStack168);
      }
      else {
        iVar2 = size(aCStack168);
        memset(__s,0,iVar2 + 1);
        uVar4 = size(aCStack168);
        read(aCStack168,(char *)__s,uVar4);
        CString((CString *)local_88,(char *)__s);
        strlen(sKeyCodeTagName);
                    /* try { // try from 10012d4c to 10012e9f has its CatchHandler @ 10012f74 */
        uVar4 = rfind((char *)local_88,(uint)sKeyCodeTagName,0xffffffff);
        strlen(s_Cannot_read_public_certificate_f_1001fe00 + 0x28);
        iVar2 = find((char *)local_88,(uint)(s_Cannot_read_public_certificate_f_1001fe00 + 0x28),
                     uVar4);
        bVar1 = uVar4 != 0xffffffff && iVar2 != -1;
        bVar8 = bVar1 << 1;
        if (bVar1) {
          local_28[0] = 0;
          this_00 = (CKeyGen *)instance();
          puVar5 = (uchar *)generateHMAC(this_00,__s,iVar2 + 1,local_28);
          bVar8 = (puVar5 == (uchar *)0x0) << 1;
          if (puVar5 == (uchar *)0x0) {
            LogFile(1,0x7947,s_failed_to_generateHMAC_10020924);
          }
          else {
            local_78 = DAT_10020cd4;
            memset(auStack119,0,0x3b);
            convert2Digits(puVar5,0x14,&local_78);
            iVar6 = strncmp(&local_78,(char *)(__s + iVar2 + 1),0x18);
            bVar8 = (iVar6 == 0) << 1;
            if (iVar6 == 0) {
              *(undefined *)(*(int *)(this + 0x20) + *(int *)(*(int *)(this + 0x20) + -0xc)) =
                   _S_terminal;
              iVar2 = strncmp(*(char **)(this + 0x20),(char *)(__s + iVar2 + 1),0x18);
              bVar8 = (iVar2 == 0) << 1;
              if (iVar2 == 0) {
                operator_delete(__s);
                close(aCStack168);
                piVar7 = (int *)(local_88[0] + -4);
                do {
                  iVar2 = *piVar7;
                  if (in_RESERVE != '\0') {
                    iVar6 = storeWordConditionalIndexed(iVar2 + -1,0,piVar7);
                    *piVar7 = iVar6;
                  }
                } while (!(bool)(bVar8 >> 1 & 1));
                if (iVar2 < 1) {
                  _M_destroy((allocator *)(local_88[0] + -0xc));
                }
                _CFile(aCStack168);
                return 1;
              }
              operator_delete(__s);
                    /* try { // try from 10012ee8 to 10012eeb has its CatchHandler @ 10012f74 */
              close(aCStack168);
              piVar7 = (int *)(local_88[0] + -4);
              do {
                iVar2 = *piVar7;
                if (in_RESERVE != '\0') {
                  iVar6 = storeWordConditionalIndexed(iVar2 + -1,0,piVar7);
                  *piVar7 = iVar6;
                }
              } while (!(bool)(bVar8 >> 1 & 1));
              if (iVar2 < 1) {
                _M_destroy((allocator *)(local_88[0] + -0xc));
              }
              _CFile(aCStack168);
              return 3;
            }
          }
          operator_delete(__s);
                    /* try { // try from 10012f34 to 10012f37 has its CatchHandler @ 10012f74 */
          close(aCStack168);
          piVar7 = (int *)(local_88[0] + -4);
          do {
            iVar2 = *piVar7;
            if (in_RESERVE != '\0') {
              iVar6 = storeWordConditionalIndexed(iVar2 + -1,0,piVar7);
              *piVar7 = iVar6;
            }
          } while (!(bool)(bVar8 >> 1 & 1));
        }
        else {
          LogFile(1,0x7946,s_failed_to_find_keycode_tag_10020908);
          operator_delete(__s);
          close(aCStack168);
          piVar7 = (int *)(local_88[0] + -4);
          do {
            iVar2 = *piVar7;
            if (in_RESERVE != '\0') {
              iVar6 = storeWordConditionalIndexed(iVar2 + -1,0,piVar7);
              *piVar7 = iVar6;
            }
          } while (!(bool)(bVar8 >> 1 & 1));
        }
        if (iVar2 < 1) {
          _M_destroy((allocator *)(local_88[0] + -0xc));
        }
      }
    }
    _CFile(aCStack168);
  }
  return 2;
}

