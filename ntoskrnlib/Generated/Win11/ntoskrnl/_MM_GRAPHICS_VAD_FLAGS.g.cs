#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MM_GRAPHICS_VAD_FLAGS
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
        public uint GraphicsAlwaysSet;
        [FieldOffset(0)]
        public uint GraphicsUseCoherentBus;
        [FieldOffset(0)]
        public uint GraphicsNoCache;
        [FieldOffset(0)]
        public uint GraphicsPageProtection;
    }
}