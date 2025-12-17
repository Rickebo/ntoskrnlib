#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _SE_AUDIT_PROCESS_CREATION_INFO
    {
        [FieldOffset(0)]
        public IntPtr ImageFileName;
    }
}