#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _MI_PARTITION_WORKING_SET
    {
        [FieldOffset(0)]
        public _MMSUPPORT_INSTANCE VmInstance;
        [FieldOffset(192)]
        public _MMWSL_INSTANCE VmWorkingSetList;
    }
}