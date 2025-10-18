using System;
using System.Runtime.InteropServices;

#pragma warning disable 0649 // Field is never assigned
[StructLayout(LayoutKind.Explicit, Size=48)]
public struct _SEP_RM_LSA_CONNECTION_STATE
{
    [FieldOffset(0)]
    public IntPtr LsaProcessHandle;
    [FieldOffset(8)]
    public IntPtr LsaCommandPortHandle;
    [FieldOffset(16)]
    public IntPtr SepRmThreadHandle;
    [FieldOffset(24)]
    public IntPtr RmCommandPortHandle;
    [FieldOffset(32)]
    public IntPtr RmCommandServerPortHandle;
    [FieldOffset(40)]
    public byte LsaCommandPortActive;
}
