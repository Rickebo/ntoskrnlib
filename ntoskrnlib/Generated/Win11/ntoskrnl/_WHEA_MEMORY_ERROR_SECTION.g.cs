#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _WHEA_MEMORY_ERROR_SECTION
    {
        [FieldOffset(0)]
        public _WHEA_MEMORY_ERROR_SECTION_VALIDBITS ValidBits;
        [FieldOffset(8)]
        public _WHEA_ERROR_STATUS ErrorStatus;
        [FieldOffset(16)]
        public ulong PhysicalAddress;
        [FieldOffset(24)]
        public ulong PhysicalAddressMask;
        [FieldOffset(32)]
        public ushort Node;
        [FieldOffset(34)]
        public ushort Card;
        [FieldOffset(36)]
        public ushort Module;
        [FieldOffset(38)]
        public ushort Bank;
        [FieldOffset(40)]
        public ushort Device;
        [FieldOffset(42)]
        public ushort Row;
        [FieldOffset(44)]
        public ushort Column;
        [FieldOffset(46)]
        public ushort BitPosition;
        [FieldOffset(48)]
        public ulong RequesterId;
        [FieldOffset(56)]
        public ulong ResponderId;
        [FieldOffset(64)]
        public ulong TargetId;
        [FieldOffset(72)]
        public byte ErrorType;
        [FieldOffset(73)]
        public byte Extended;
        [FieldOffset(74)]
        public ushort RankNumber;
        [FieldOffset(76)]
        public ushort CardHandle;
        [FieldOffset(78)]
        public ushort ModuleHandle;
    }
}