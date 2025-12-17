#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _SUBSECTION
    {
        [FieldOffset(0)]
        public IntPtr ControlArea;
        [FieldOffset(8)]
        public IntPtr SubsectionBase;
        [FieldOffset(16)]
        public IntPtr NextSubsection;
        [FieldOffset(24)]
        public _RTL_AVL_TREE GlobalPerSessionHead;
        [FieldOffset(24)]
        public IntPtr CreationWaitList;
        [FieldOffset(32)]
        public _MMSUBSECTION_FLAGS SubsectionFlags;
        [FieldOffset(36)]
        public uint StartingSector;
        [FieldOffset(40)]
        public uint NumberOfFullSectors;
        [FieldOffset(44)]
        public uint PtesInSubsection;
        [FieldOffset(48)]
        public _unnamed_tag_ u1;
        [FieldOffset(52)]
        public uint UnusedPtes;
        [FieldOffset(52)]
        public uint ExtentQueryNeeded;
        [FieldOffset(52)]
        public uint Spare;
    }
}