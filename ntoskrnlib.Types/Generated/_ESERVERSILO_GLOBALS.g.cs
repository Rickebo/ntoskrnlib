using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=1432)]
public struct _ESERVERSILO_GLOBALS
{
    [FieldOffset(0)]
    public _OBP_SILODRIVERSTATE ObSiloState;
    [FieldOffset(736)]
    public _SEP_SILOSTATE SeSiloState;
    [FieldOffset(784)]
    public _SEP_RM_LSA_CONNECTION_STATE SeRmSiloState;
    [FieldOffset(832)]
    public IntPtr EtwSiloState;
    [FieldOffset(840)]
    public IntPtr PspSessionLeaderProcess;
    [FieldOffset(848)]
    public IntPtr ExpDefaultErrorPortProcess;
    [FieldOffset(856)]
    public IntPtr ExpDefaultErrorPort;
    [FieldOffset(864)]
    public uint HardErrorState;
    [FieldOffset(872)]
    public IntPtr ExpLicenseState;
    [FieldOffset(880)]
    public _WNF_SILODRIVERSTATE WnfSiloState;
    [FieldOffset(936)]
    public _DBGK_SILOSTATE DbgkSiloState;
    [FieldOffset(968)]
    public _UNICODE_STRING PsProtectedCurrentDirectory;
    [FieldOffset(984)]
    public _UNICODE_STRING PsProtectedEnvironment;
    [FieldOffset(1000)]
    public IntPtr ApiSetSection;
    [FieldOffset(1008)]
    public IntPtr ApiSetSchema;
    [FieldOffset(1016)]
    public byte OneCoreForwardersEnabled;
    [FieldOffset(1024)]
    public IntPtr NlsState;
    [FieldOffset(1032)]
    public _RTL_NLS_STATE RtlNlsState;
    [FieldOffset(1216)]
    public IntPtr ImgFileExecOptions;
    [FieldOffset(1224)]
    public IntPtr ExTimeZoneState;
    [FieldOffset(1232)]
    public _UNICODE_STRING NtSystemRoot;
    [FieldOffset(1248)]
    public _UNICODE_STRING SiloRootDirectoryName;
    [FieldOffset(1264)]
    public IntPtr Storage;
    [FieldOffset(1272)]
    public IntPtr State;
    [FieldOffset(1276)]
    public int ExitStatus;
    [FieldOffset(1280)]
    public IntPtr DeleteEvent;
    [FieldOffset(1288)]
    public IntPtr UserSharedData;
    [FieldOffset(1296)]
    public IntPtr UserSharedSection;
    [FieldOffset(1304)]
    public _WORK_QUEUE_ITEM TerminateWorkItem;
    [FieldOffset(1336)]
    public uint ContainerBuildNumber;
    [FieldOffset(1340)]
    public int CriticalProcessExited;
    [FieldOffset(1344)]
    public int CriticalProcessStatus;
    [FieldOffset(1348)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=15)]
    public byte[] CriticalProcessName;
    [FieldOffset(1368)]
    public _CRITICAL_PROCESS_EXCEPTION_DATA CriticalProcessExceptionData;
    [FieldOffset(1416)]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst=4)]
    public uint[] RtlFunctionalityCache;
}
