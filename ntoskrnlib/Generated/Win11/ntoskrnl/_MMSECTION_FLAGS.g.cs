#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMSECTION_FLAGS
    {
        [FieldOffset(0)]
        public uint BeingDeleted;
        [FieldOffset(0)]
        public uint BeingCreated;
        [FieldOffset(0)]
        public uint BeingPurged;
        [FieldOffset(0)]
        public uint NoModifiedWriting;
        [FieldOffset(0)]
        public uint FailAllIo;
        [FieldOffset(0)]
        public uint Image;
        [FieldOffset(0)]
        public uint Based;
        [FieldOffset(0)]
        public uint File;
        [FieldOffset(0)]
        public uint SectionOfInterest;
        [FieldOffset(0)]
        public uint PrefetchCreated;
        [FieldOffset(0)]
        public uint PhysicalMemory;
        [FieldOffset(0)]
        public uint ImageControlAreaOnRemovableMedia;
        [FieldOffset(0)]
        public uint Reserve;
        [FieldOffset(0)]
        public uint Commit;
        [FieldOffset(0)]
        public uint NoChange;
        [FieldOffset(0)]
        public uint WasPurged;
        [FieldOffset(0)]
        public uint UserReference;
        [FieldOffset(0)]
        public uint GlobalMemory;
        [FieldOffset(0)]
        public uint DeleteOnClose;
        [FieldOffset(0)]
        public uint FilePointerNull;
        [FieldOffset(0)]
        public uint PreferredNode;
        [FieldOffset(0)]
        public uint GlobalOnlyPerSession;
        [FieldOffset(0)]
        public uint ControlAreaOnUnusedList;
        [FieldOffset(0)]
        public uint SystemVaAllocated;
        [FieldOffset(0)]
        public uint NotBeingUsed;
        [FieldOffset(0)]
        public uint PageSize64K;
    }
}