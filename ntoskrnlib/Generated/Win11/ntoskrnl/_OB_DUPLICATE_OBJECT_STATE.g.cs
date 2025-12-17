#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _OB_DUPLICATE_OBJECT_STATE
    {
        [FieldOffset(0)]
        public IntPtr SourceProcess;
        [FieldOffset(8)]
        public IntPtr SourceHandle;
        [FieldOffset(16)]
        public IntPtr Object;
        [FieldOffset(24)]
        public uint TargetAccess;
        [FieldOffset(28)]
        public _HANDLE_TABLE_ENTRY_INFO ObjectInfo;
        [FieldOffset(36)]
        public uint HandleAttributes;
    }
}