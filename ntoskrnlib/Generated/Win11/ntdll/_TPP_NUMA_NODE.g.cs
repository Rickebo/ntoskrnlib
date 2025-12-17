#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _TPP_NUMA_NODE
    {
        [FieldOffset(0)]
        public int WorkerCount;
    }
}