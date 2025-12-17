#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PPM_COORDINATED_SELECTION
    {
        [FieldOffset(0)]
        public uint MaximumStates;
        [FieldOffset(4)]
        public uint SelectedStates;
        [FieldOffset(8)]
        public uint DefaultSelection;
        [FieldOffset(16)]
        public IntPtr Selection;
    }
}