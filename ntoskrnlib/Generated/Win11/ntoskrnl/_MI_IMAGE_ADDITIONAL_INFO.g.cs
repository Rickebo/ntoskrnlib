#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _MI_IMAGE_ADDITIONAL_INFO
    {
        [FieldOffset(0)]
        public _MI_PROTOTYPE_PTES_NODE ProtosNode;
        [FieldOffset(32)]
        public IntPtr DynamicRelocations;
        [FieldOffset(40)]
        public _IMAGE_SECURITY_CONTEXT SecurityContext;
        [FieldOffset(48)]
        public IntPtr ImageFileExtents;
        [FieldOffset(56)]
        public _unnamed_tag_ u;
        [FieldOffset(60)]
        public uint Unused;
        [FieldOffset(64)]
        public ulong StrongImageReference;
    }
}