#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KI_AVAILABLE_CPUS_WORK_STATE
    {
        [FieldOffset(0)]
        public uint WorkerExecuting;
        [FieldOffset(0)]
        public uint WorkPresent;
        [FieldOffset(0)]
        public uint Reserved;
        [FieldOffset(0)]
        public uint AllFields;
    }
}