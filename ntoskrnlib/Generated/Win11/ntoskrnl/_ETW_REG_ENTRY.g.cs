#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _ETW_REG_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY RegList;
        [FieldOffset(16)]
        public _LIST_ENTRY GroupRegList;
        [FieldOffset(32)]
        public IntPtr GuidEntry;
        [FieldOffset(40)]
        public IntPtr GroupEntry;
        [FieldOffset(48)]
        public IntPtr ReplyQueue;
        [FieldOffset(48)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public IntPtr[] ReplySlot;
        [FieldOffset(48)]
        public IntPtr Caller;
        [FieldOffset(56)]
        public uint SessionId;
        [FieldOffset(80)]
        public IntPtr Process;
        [FieldOffset(80)]
        public IntPtr CallbackContext;
        [FieldOffset(88)]
        public IntPtr Callback;
        [FieldOffset(96)]
        public ushort Index;
        [FieldOffset(98)]
        public ushort Flags;
        [FieldOffset(98)]
        public ushort DbgKernelRegistration;
        [FieldOffset(98)]
        public ushort DbgUserRegistration;
        [FieldOffset(98)]
        public ushort DbgReplyRegistration;
        [FieldOffset(98)]
        public ushort DbgClassicRegistration;
        [FieldOffset(98)]
        public ushort DbgSessionSpaceRegistration;
        [FieldOffset(98)]
        public ushort DbgModernRegistration;
        [FieldOffset(98)]
        public ushort DbgClosed;
        [FieldOffset(98)]
        public ushort DbgInserted;
        [FieldOffset(98)]
        public ushort DbgWow64;
        [FieldOffset(98)]
        public ushort DbgUseDescriptorType;
        [FieldOffset(98)]
        public ushort DbgDropProviderTraits;
        [FieldOffset(100)]
        public byte EnableMask;
        [FieldOffset(101)]
        public byte GroupEnableMask;
        [FieldOffset(102)]
        public byte HostEnableMask;
        [FieldOffset(103)]
        public byte HostGroupEnableMask;
        [FieldOffset(104)]
        public IntPtr Traits;
    }
}