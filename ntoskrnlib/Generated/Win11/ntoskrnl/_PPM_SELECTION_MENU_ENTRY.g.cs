#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PPM_SELECTION_MENU_ENTRY
    {
        [FieldOffset(0)]
        public byte StrictDependency;
        [FieldOffset(1)]
        public byte InitiatingState;
        [FieldOffset(2)]
        public byte DependentState;
        [FieldOffset(4)]
        public uint StateIndex;
        [FieldOffset(8)]
        public uint Dependencies;
        [FieldOffset(16)]
        public IntPtr DependencyList;
    }
}