#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MM_PRIVATE_VAD_FLAGS
    {
        [FieldOffset(0)]
        public uint Lock;
        [FieldOffset(0)]
        public uint LockContended;
        [FieldOffset(0)]
        public uint DeleteInProgress;
        [FieldOffset(0)]
        public uint NoChange;
        [FieldOffset(0)]
        public uint VadType;
        [FieldOffset(0)]
        public uint Protection;
        [FieldOffset(0)]
        public uint PreferredNode;
        [FieldOffset(0)]
        public uint PageSize;
        [FieldOffset(0)]
        public uint PrivateMemoryAlwaysSet;
        [FieldOffset(0)]
        public uint WriteWatch;
        [FieldOffset(0)]
        public uint FixedLargePageSize;
        [FieldOffset(0)]
        public uint ZeroFillPagesOptional;
        [FieldOffset(0)]
        public uint MemCommit;
        [FieldOffset(0)]
        public uint Graphics;
        [FieldOffset(0)]
        public uint Enclave;
        [FieldOffset(0)]
        public uint ShadowStack;
        [FieldOffset(0)]
        public uint PhysicalMemoryPfnsReferenced;
    }
}