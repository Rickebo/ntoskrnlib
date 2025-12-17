#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct _RTL_AVL_TABLE
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_LINKS BalancedRoot;
        [FieldOffset(32)]
        public IntPtr OrderedPointer;
        [FieldOffset(40)]
        public uint WhichOrderedElement;
        [FieldOffset(44)]
        public uint NumberGenericTableElements;
        [FieldOffset(48)]
        public uint DepthOfTree;
        [FieldOffset(56)]
        public IntPtr RestartKey;
        [FieldOffset(64)]
        public uint DeleteCount;
        [FieldOffset(72)]
        public IntPtr CompareRoutine;
        [FieldOffset(80)]
        public IntPtr AllocateRoutine;
        [FieldOffset(88)]
        public IntPtr FreeRoutine;
        [FieldOffset(96)]
        public IntPtr TableContext;
    }
}