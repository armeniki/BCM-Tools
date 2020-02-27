
/* CCFSServer::cbCFSServer(unsigned short, unsigned long, sNnuMfwMessage const*, unsigned long) */

void cbCFSServer(ushort param_1,ulong param_2,sNnuMfwMessage *param_3,ulong param_4)

{
  bool bVar1;
  uint uVar2;
  undefined2 in_register_0000000c;
  CCFSControl *this;
  ushort uVar4;
  CLicense *this_00;
  CComponent *this_01;
  int iVar3;
  ulong uVar5;
  char *__format;
  int *this_02;
  ulong uVar6;
  uint uVar7;
  undefined4 uVar8;
  undefined4 *puVar9;
  sNnuMfwMessage *psVar10;
  char acStack776 [512];
  undefined1 *local_108;
  char local_104;
  undefined4 local_f8;
  undefined4 local_f4;
  undefined4 local_f0;
  undefined4 local_ec;
  undefined4 local_e8;
  undefined4 local_e4;
  undefined4 local_d8;
  undefined4 local_d4;
  undefined4 local_d0;
  undefined4 local_cc;
  undefined4 local_c8;
  undefined4 local_c4;
  undefined4 local_b8;
  undefined4 local_b4;
  undefined4 local_b0;
  undefined4 local_ac;
  undefined4 local_a8;
  undefined4 local_a4;
  undefined4 local_98;
  undefined4 local_94;
  undefined4 local_90;
  undefined4 local_8c;
  undefined4 local_88;
  undefined4 local_84;
  undefined4 local_78;
  undefined4 local_74;
  undefined4 local_70;
  undefined4 local_6c;
  undefined4 local_68;
  undefined4 local_64;
  undefined4 local_58;
  undefined4 local_54;
  undefined4 local_50;
  undefined4 local_4c;
  undefined4 local_48;
  undefined4 local_44;
  uint local_38;
  uint local_34;
  ulong local_30;
  int local_2c;
  int local_28 [4];
  
  if (param_3 == (sNnuMfwMessage *)0x0) {
    return;
  }
  sprintf(acStack776,s_cbCFSServer_received_a_message_f_1001f240,*(undefined4 *)(param_3 + 0x14),
          CONCAT22(in_register_0000000c,param_1),param_2,(uint)(byte)param_3[0x18],param_4);
  LogFile(4,0x7923,acStack776);
  local_38 = 0;
  local_34 = 0;
  bVar1 = false;
  this = (CCFSControl *)instance();
  if (this == (CCFSControl *)0x0) {
    uVar4 = 1;
    uVar5 = 0x7924;
    __format = s_failed_to_find_control_object__1001f170;
    goto LAB_10009800;
  }
  this_00 = (CLicense *)instance();
  if (this_00 == (CLicense *)0x0) {
    uVar4 = 1;
    uVar5 = 0x7925;
    __format = s_failed_to_find_license_object__1001f29c;
    goto LAB_10009800;
  }
  puVar9 = (undefined4 *)(param_3 + 0x18);
  sprintf(acStack776,s_cbCFSServer_clientMsg_header_____1001f2bc,*(undefined4 *)(param_3 + 0x18),
          *(undefined4 *)(param_3 + 0x1c),*(undefined4 *)(param_3 + 0x20),
          *(undefined4 *)(param_3 + 0x24),*(undefined4 *)(param_3 + 0x28),
          *(undefined4 *)(param_3 + 0x2c));
  LogFile(4,0x7926,acStack776);
  switch(*(undefined4 *)(param_3 + 0x20)) {
  case 0:
    switch(*(undefined4 *)(param_3 + 0x24)) {
    case 0:
      sprintf(acStack776,s_CompNameMsgType__s_1001f2f8,param_3 + 0x34);
      LogFile(4,0x7927,acStack776);
      if (param_3[0x34] == (sNnuMfwMessage)0x0) {
        uVar4 = 2;
        uVar5 = 0x7928;
        __format = s_Name_Msg_has_no_name_1001f30c;
        break;
      }
      if (*(int *)(param_3 + 0x30) == 0) {
        LogFile(2,0x7928,s_Name_Msg_has_no_process_id_1001f324);
      }
      this_01 = (CComponent *)findCompByName(this,(char *)(param_3 + 0x34));
      if (this_01 == (CComponent *)0x0) {
        this_01 = (CComponent *)operator_new(0x574);
                    /* try { // try from 10008fd4 to 10008fd7 has its CatchHandler @ 10008fdc */
        CComponent(this_01,(CMediator *)this);
        if (this_01 == (CComponent *)0x0) {
          uVar4 = 1;
          uVar5 = 0x7994;
          __format = s_failed_to_new_obj_1001e708;
          break;
        }
        bVar1 = true;
      }
      local_108 = oMutex;
      local_104 = (**(code **)(oMutex._0_4_ + 8))();
      local_f8 = *puVar9;
      local_f4 = *(undefined4 *)(param_3 + 0x1c);
      local_f0 = *(undefined4 *)(param_3 + 0x20);
      local_ec = *(undefined4 *)(param_3 + 0x24);
      local_e8 = *(undefined4 *)(param_3 + 0x28);
      local_e4 = *(undefined4 *)(param_3 + 0x2c);
                    /* try { // try from 10009078 to 100090c3 has its CatchHandler @ 100090c8 */
      init(this_01,(CCFSMessageHeader)&local_f8,(char *)(param_3 + 0x34),0,(char *)0x0);
      if (bVar1) {
        clearFeatureArray(this_01);
        notifyAllFeatures(this_01);
        addComponent(this,this_01);
      }
      else {
        if (*(int *)(this_01 + 0x2c) != *(int *)(param_3 + 0x30)) {
          clearFeatureArray(this_01);
          notifyAllFeatures(this_01);
        }
      }
      if (local_104 != '\0') {
        (**(code **)(*(int *)local_108 + 0x10))();
      }
      *(undefined4 *)(this_01 + 0x2c) = *(undefined4 *)(param_3 + 0x30);
      uVar2 = *(uint *)(param_3 + 0x48);
      *(uint *)(this_01 + 0x24c) = uVar2;
      uVar7 = 0;
      if (uVar2 != 0) {
        do {
          uVar8 = (puVar9 + uVar7 * 2)[0xe];
          *(undefined4 *)(this_01 + uVar7 * 8 + 0x250) = (puVar9 + uVar7 * 2)[0xd];
          *(undefined4 *)(this_01 + uVar7 * 8 + 0x254) = uVar8;
          uVar7 = uVar7 + 1;
        } while (uVar7 < uVar2);
      }
      goto LAB_10009214;
    case 1:
      sprintf(acStack776,s_InitListMsgType_0x_x_1001f340,*(undefined4 *)(param_3 + 0x2c));
      LogFile(4,0x792a,acStack776);
      this_01 = (CComponent *)findCompByMFW(this,*(ulong *)(param_3 + 0x2c));
      if (this_01 == (CComponent *)0x0) goto LAB_1000955c;
      sprintf(acStack776,s_found_comp_with_name__s_1001f358,this_01 + 0x30);
      LogFile(4,0x792c,acStack776);
      local_d8 = *puVar9;
      local_d4 = *(undefined4 *)(param_3 + 0x1c);
      local_d0 = *(undefined4 *)(param_3 + 0x20);
      local_cc = *(undefined4 *)(param_3 + 0x24);
      local_c8 = *(undefined4 *)(param_3 + 0x28);
      local_c4 = *(undefined4 *)(param_3 + 0x2c);
      init(this_01,(CCFSMessageHeader)&local_d8,(char *)(param_3 + 0x34),0,(char *)0x0);
      *(undefined4 *)(this_01 + 0x240) = 0;
      *(undefined4 *)(this_01 + 0x244) = 0;
LAB_10009214:
      uVar5 = 0;
      uVar6 = 0;
LAB_10009300:
      sendMessage(this_01,0,uVar5,uVar6);
      return;
    case 2:
      LogFile(4,0x792d,s_cbCFSServer_recv_nCFSClientGetFe_1001f370);
      this_01 = (CComponent *)findCompByMFW(this,*(ulong *)(param_3 + 0x2c));
      if (this_01 != (CComponent *)0x0) {
        sprintf(acStack776,s_find_comp_with_name__s_1001f3c0,this_01 + 0x30);
        LogFile(4,0x792f,acStack776);
        local_b8 = *puVar9;
        local_b4 = *(undefined4 *)(param_3 + 0x1c);
        local_b0 = *(undefined4 *)(param_3 + 0x20);
        local_ac = *(undefined4 *)(param_3 + 0x24);
        local_a8 = *(undefined4 *)(param_3 + 0x28);
        local_a4 = *(undefined4 *)(param_3 + 0x2c);
        init(this_01,(CCFSMessageHeader)&local_b8,(char *)(param_3 + 0x34),0,(char *)0x0);
        getNextFeatureList(this_01,&local_38,&local_34);
        uVar5 = local_38;
        uVar6 = local_34;
        goto LAB_10009300;
      }
      __format = s_failed_to_find_component___d__1001f3a0;
      goto LAB_10009258;
    case 3:
      LogFile(4,0x7930,s_cbCFSServer_recv_nCFSClientStart_1001f3d8);
      this_01 = (CComponent *)findCompByMFW(this,*(ulong *)(param_3 + 0x2c));
      if (this_01 != (CComponent *)0x0) {
        sprintf(acStack776,s_found_comp_with_name__s_1001f358,this_01 + 0x30);
        LogFile(4,0x7931,acStack776);
        local_98 = *puVar9;
        local_94 = *(undefined4 *)(param_3 + 0x1c);
        local_90 = *(undefined4 *)(param_3 + 0x20);
        local_8c = *(undefined4 *)(param_3 + 0x24);
        local_88 = *(undefined4 *)(param_3 + 0x28);
        local_84 = *(undefined4 *)(param_3 + 0x2c);
        init(this_01,(CCFSMessageHeader)&local_98,(char *)(param_3 + 0x34),0,(char *)0x0);
        this_01[0x248] = (CComponent)0x1;
LAB_100094fc:
        uVar5 = 0;
        uVar6 = 0;
LAB_1000950c:
        sendMessage(this_01,0,uVar5,uVar6);
        auditFeature(this_01);
        return;
      }
      goto LAB_1000955c;
    case 4:
      uVar4 = 4;
      uVar5 = 0x7932;
      __format = s_cbCFSServer_recv_nCFSClientServe_1001f408;
      break;
    case 5:
      uVar4 = 4;
      uVar5 = 0x7933;
      __format = s_cbCFSServer_recv_nCFSClientWrite_1001f438;
      break;
    default:
      uVar4 = 4;
      uVar5 = 0x7934;
      __format = s_cbCFSServer_recv_unknown__1001f468;
    }
    goto LAB_10009800;
  case 1:
    LogFile(4,0x7935,s_cbCFSServer_recv_clientReplyMsg__1001f484);
    if (*(int *)(param_3 + 0x24) == 5) {
      sprintf(acStack776,s_WriteReplyMsgType___d__s__1001f4a8,*(undefined4 *)(param_3 + 0x34),
              param_3 + 0x38);
      LogFile(4,0x7936,acStack776);
      this_01 = (CComponent *)findCompByMFW(this,*(ulong *)(param_3 + 0x2c));
      if (this_01 != (CComponent *)0x0) {
        sprintf(acStack776,s_found_comp_with_name__s_1001f358,this_01 + 0x30);
        LogFile(4,0x7937,acStack776);
        local_78 = *puVar9;
        local_74 = *(undefined4 *)(param_3 + 0x1c);
        local_70 = *(undefined4 *)(param_3 + 0x20);
        local_6c = *(undefined4 *)(param_3 + 0x24);
        local_68 = *(undefined4 *)(param_3 + 0x28);
        local_64 = *(undefined4 *)(param_3 + 0x2c);
        init(this_01,(CCFSMessageHeader)&local_78,(char *)0x0,*(uint *)(param_3 + 0x34),
             (char *)(param_3 + 0x38));
        iVar3 = replyFeatureArray(this_01);
        if (iVar3 != 0) {
          sprintf(acStack776,s_sendMessage_with___d___d__1001f4c4,*(undefined4 *)(iVar3 + 0x10),
                  *(undefined4 *)(iVar3 + 0x14));
          LogFile(4,0x7938,acStack776);
          uVar5 = *(ulong *)(iVar3 + 0x10);
          uVar6 = *(ulong *)(iVar3 + 0x14);
          goto LAB_1000950c;
        }
        goto LAB_100094fc;
      }
    }
    else {
      if (*(int *)(param_3 + 0x24) != 6) {
        uVar4 = 2;
        uVar5 = 0x793b;
        __format = s_cbCFSServer_recv_unknown_msg__1001f518;
        goto LAB_10009800;
      }
      sprintf(acStack776,s_ShutdownMsgType___d__s__1001f4e0,*(undefined4 *)(param_3 + 0x34),
              param_3 + 0x38);
      LogFile(4,0x7939,acStack776);
      this_02 = (int *)findCompByMFW(this,*(ulong *)(param_3 + 0x2c));
      if (this_02 != (int *)0x0) {
        sprintf(acStack776,s_found_comp_with_name__s_1001f358,this_02 + 0xc);
        LogFile(4,0x793a,acStack776);
        local_58 = *puVar9;
        local_54 = *(undefined4 *)(param_3 + 0x1c);
        local_50 = *(undefined4 *)(param_3 + 0x20);
        local_4c = *(undefined4 *)(param_3 + 0x24);
        local_48 = *(undefined4 *)(param_3 + 0x28);
        local_44 = *(undefined4 *)(param_3 + 0x2c);
        init((CComponent *)this_02,(CCFSMessageHeader)&local_58,(char *)0x0,
             *(uint *)(param_3 + 0x34),(char *)(param_3 + 0x38));
        removeFeatureArray((CComponent *)this_02);
        clearFeatureArray((CComponent *)this_02);
        delComponent(this,(CComponent *)this_02);
        if (this_02 == (int *)0x0) {
          return;
        }
        (**(code **)(*this_02 + 4))(this_02);
        return;
      }
    }
LAB_1000955c:
    __format = s_failed_to_find_component___d__1001f4f8;
LAB_10009258:
    sprintf(acStack776,__format,*(undefined4 *)(param_3 + 0x2c));
    uVar5 = 0x792b;
    break;
  default:
    uVar4 = 2;
    uVar5 = 0x7943;
    __format = s_cbCFSServer_recv_unknown_1001f658;
    goto LAB_10009800;
  case 0xb:
    LogFile(4,0x793c,s_cbCFSServer_recv_OAMActiveFeatur_1001f538);
    local_30 = 0;
    __format = (char *)packLicense(this_00,&local_30);
    if (__format != (char *)0x0) {
      sendMessage(this_00,0xb,__format,local_30,*(ulong *)(param_3 + 0x28),
                  *(ulong *)(param_3 + 0x2c));
      operator_delete__(__format);
      return;
    }
    sprintf(acStack776,s_OAMFeautreList_packing_error__1001f55c);
    uVar5 = 0x793d;
    break;
  case 0xc:
    LogFile(4,0x793e,s_cbCFSServer_recv_ValidateRequest_1001f57c);
    local_2c = 2;
    psVar10 = param_3 + 0x30;
    if (psVar10 == (sNnuMfwMessage *)0x0) {
      LogFile(2,0x793f,s_ValidateRequest_wrong_file_name_1001f5a8);
    }
    else {
      local_2c = validate(this_00,(char *)psVar10);
    }
    sprintf(acStack776,s_OAMValidate__s_rc__d_1001f5c8,psVar10,local_2c);
    LogFile(4,0x7940,acStack776);
    this_02 = &local_2c;
    goto LAB_100097e0;
  case 0xd:
    LogFile(4,0x7941,s_cbCFSServer_recv_ActivateRequest_1001f5e0);
    local_28[0] = 2;
    psVar10 = param_3 + 0x30;
    if (psVar10 == (sNnuMfwMessage *)0x0) {
      LogFile(2,0x7942,s_ActivateRequest_wrong_file_name_1001f60c);
    }
    else {
      local_28[0] = validate(this_00,(char *)psVar10);
    }
    sprintf(acStack776,s_OAMValidate1__s_rc__d_1001f62c,psVar10,local_28[0]);
    LogFile(4,0x7940,acStack776);
    if (local_28[0] == 1 || local_28[0] == 3) {
      local_28[0] = activateFile(this_00,(char *)psVar10);
    }
    sprintf(acStack776,s_OAMActivate2_rc__d_1001f644,local_28[0]);
    LogFile(4,0x7940,acStack776);
    this_02 = local_28;
LAB_100097e0:
    sendMessage(this_00,0xc,(char *)this_02,4,*(ulong *)(param_3 + 0x28),*(ulong *)(param_3 + 0x2c))
    ;
    return;
  }
  uVar4 = 2;
  __format = acStack776;
LAB_10009800:
  LogFile(uVar4,uVar5,__format);
  return;
}

