#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MI_PARTITION_FLAGS
    {
        [FieldOffset(0)]
        public uint BeingDeleted;
        [FieldOffset(0)]
        public uint PageListsInitialized;
        [FieldOffset(0)]
        public uint StoreReservedPagesCharged;
        [FieldOffset(0)]
        public uint UseProtectedSlabAllocators;
        [FieldOffset(0)]
        public uint PureHolding;
        [FieldOffset(0)]
        public uint ZeroPagesOptional;
        [FieldOffset(0)]
        public uint BackgroundZeroingDisabled;
        [FieldOffset(0)]
        public uint SpecialPurposeMemory;
        [FieldOffset(0)]
        public int EntireField;
    }
}