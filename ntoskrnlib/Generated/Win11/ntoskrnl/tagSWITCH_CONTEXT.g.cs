#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 856)]
    public partial struct tagSWITCH_CONTEXT
    {
        [FieldOffset(0)]
        public tagSWITCH_CONTEXT_ATTRIBUTE Attribute;
        [FieldOffset(24)]
        public tagSWITCH_CONTEXT_DATA Data;
    }
}