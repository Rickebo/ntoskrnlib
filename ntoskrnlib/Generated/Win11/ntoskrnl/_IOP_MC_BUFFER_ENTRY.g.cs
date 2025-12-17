#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _IOP_MC_BUFFER_ENTRY
    {
        [FieldOffset(0)]
        public ushort Type;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        public int ReferenceCount;
        [FieldOffset(12)]
        public uint Flags;
        [FieldOffset(16)]
        public _LIST_ENTRY GlobalDataLink;
        [FieldOffset(32)]
        public IntPtr Address;
        [FieldOffset(40)]
        public uint Length;
        [FieldOffset(44)]
        public sbyte AccessMode;
        [FieldOffset(48)]
        public int MdlRef;
        [FieldOffset(56)]
        public IntPtr Mdl;
        [FieldOffset(64)]
        public _KEVENT MdlRundownEvent;
        [FieldOffset(88)]
        public IntPtr PfnArray;
        [FieldOffset(96)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _IOP_MC_BE_PAGE_NODE[] PageNodes;
    }
}