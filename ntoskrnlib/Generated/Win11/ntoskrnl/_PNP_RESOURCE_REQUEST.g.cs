#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _PNP_RESOURCE_REQUEST
    {
        [FieldOffset(0)]
        public IntPtr PhysicalDevice;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(12)]
        public uint AllocationType;
        [FieldOffset(16)]
        public uint Priority;
        [FieldOffset(20)]
        public uint Position;
        [FieldOffset(24)]
        public IntPtr ResourceRequirements;
        [FieldOffset(32)]
        public IntPtr ReqList;
        [FieldOffset(40)]
        public IntPtr ResourceAssignment;
        [FieldOffset(48)]
        public IntPtr TranslatedResourceAssignment;
        [FieldOffset(56)]
        public int Status;
    }
}