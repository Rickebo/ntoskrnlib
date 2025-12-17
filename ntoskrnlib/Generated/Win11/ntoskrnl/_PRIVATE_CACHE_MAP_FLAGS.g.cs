#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PRIVATE_CACHE_MAP_FLAGS
    {
        [FieldOffset(0)]
        public uint DontUse;
        [FieldOffset(0)]
        public uint ReadAheadActive;
        [FieldOffset(0)]
        public uint ReadAheadEnabled;
        [FieldOffset(0)]
        public uint PagePriority;
        [FieldOffset(0)]
        public uint PipelineReadAheads;
        [FieldOffset(0)]
        public uint Available;
        [FieldOffset(0)]
        public uint EntireField;
    }
}