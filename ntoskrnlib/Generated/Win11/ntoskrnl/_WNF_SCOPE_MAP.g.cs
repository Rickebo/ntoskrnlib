#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 176)]
    public partial struct _WNF_SCOPE_MAP
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public IntPtr SystemScopeInstance;
        [FieldOffset(16)]
        public IntPtr MachineScopeInstance;
        [FieldOffset(24)]
        public IntPtr PhysicalMachineScopeInstance;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public _WNF_SCOPE_MAP_ENTRY[] ByDataScope;
    }
}