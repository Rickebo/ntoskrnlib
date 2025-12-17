#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _MI_SYSTEM_ACCELERATORS
    {
        [FieldOffset(0)]
        public _LIST_ENTRY HardwareInstances;
        [FieldOffset(16)]
        public uint NumberOfHardwareInstances;
        [FieldOffset(20)]
        public byte ShuttingDown;
        [FieldOffset(21)]
        public byte AllocationFailures;
        [FieldOffset(22)]
        public byte AllocationQueryFailures;
        [FieldOffset(23)]
        public byte AllocationQueryBadNodes;
        [FieldOffset(24)]
        public _SINGLE_LIST_ENTRY DeferredPoolFrees;
        [FieldOffset(32)]
        public IntPtr OpaqueContext;
        [FieldOffset(40)]
        public int Lock;
    }
}