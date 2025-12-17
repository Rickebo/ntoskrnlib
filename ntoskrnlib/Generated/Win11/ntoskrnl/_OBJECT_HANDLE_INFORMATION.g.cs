#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _OBJECT_HANDLE_INFORMATION
    {
        [FieldOffset(0)]
        public uint HandleAttributes;
        [FieldOffset(4)]
        public uint GrantedAccess;
    }
}