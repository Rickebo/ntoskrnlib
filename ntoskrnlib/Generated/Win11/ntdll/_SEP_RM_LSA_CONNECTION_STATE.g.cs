#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _SEP_RM_LSA_CONNECTION_STATE
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
}