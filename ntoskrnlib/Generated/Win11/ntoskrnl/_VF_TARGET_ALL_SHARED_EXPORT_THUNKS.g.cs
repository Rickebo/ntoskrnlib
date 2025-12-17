#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _VF_TARGET_ALL_SHARED_EXPORT_THUNKS
    {
        [FieldOffset(0)]
        public IntPtr SharedExportThunks;
        [FieldOffset(8)]
        public IntPtr PoolSharedExportThunks;
        [FieldOffset(16)]
        public IntPtr XdvSharedExportThunks;
    }
}