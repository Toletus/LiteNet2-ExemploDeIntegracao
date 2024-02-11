﻿namespace Toletus.SM25.Command.Enums;

public enum Commands
{
    Undefined = 0x0000,
    Verify = 0x0101,
    Identify = 0x0102,
    Enroll = 0x0103,
    EnrollOneTime = 0x0104,
    ClearTemplate = 0x0105,
    ClearAllTemplate = 0x0106,
    GetEmptyID = 0x0107,
    GetTemplateStatus = 0x0108,
    GetBrokenTemplate = 0x0109,
    ReadTemplate = 0x010A,
    WriteTemplate = 0x010B,
    SetSecurityLevel = 0x010C,
    GetSecurityLevel = 0x010D,
    SetFingerTimeOut = 0x010E,
    GetFingerTimeOut = 0x010F,
    SetDeviceID = 0x0110,
    GetDeviceID = 0x0111,
    GetFWVersion = 0x0112,
    FingerDetect = 0x0113,
    SetBaudRate = 0x0114,
    SetDuplicationCheck = 0x0115,
    GetDuplicationCheck = 0x0116,
    EnterStadbyMode = 0x0117,
    EnrollAndStoreinRAM = 0x0118,
    GetEnrollData = 0x0119,
    GetFeatureDataofCapturedFP = 0x011A,
    VerifyDownloadedFeatureWithCapturedFP = 0x011B,
    IdentifyDownloadedFeatureWithCapturedFP = 0x011C,
    GetDeviceName = 0x0121,
    SensorLedControl = 0x0124,
    IdentifyFree = 0x0125,
    SetDevicePassword = 0x0126,
    VerifyDevicePassword = 0x0127,
    GetEnrollCount = 0x0128,
    FPCancel = 0x0130,
    TestConnection = 0x0150,
    IncorrectCommand = 0x0160,
    Unknow
}