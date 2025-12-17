#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_MEMORY_ERROR_SECTION_VALIDBITS
    {
        [FieldOffset(0)]
        public ulong ErrorStatus;
        [FieldOffset(0)]
        public ulong PhysicalAddress;
        [FieldOffset(0)]
        public ulong PhysicalAddressMask;
        [FieldOffset(0)]
        public ulong Node;
        [FieldOffset(0)]
        public ulong Card;
        [FieldOffset(0)]
        public ulong Module;
        [FieldOffset(0)]
        public ulong Bank;
        [FieldOffset(0)]
        public ulong Device;
        [FieldOffset(0)]
        public ulong Row;
        [FieldOffset(0)]
        public ulong Column;
        [FieldOffset(0)]
        public ulong BitPosition;
        [FieldOffset(0)]
        public ulong RequesterId;
        [FieldOffset(0)]
        public ulong ResponderId;
        [FieldOffset(0)]
        public ulong TargetId;
        [FieldOffset(0)]
        public ulong ErrorType;
        [FieldOffset(0)]
        public ulong RankNumber;
        [FieldOffset(0)]
        public ulong CardHandle;
        [FieldOffset(0)]
        public ulong ModuleHandle;
        [FieldOffset(0)]
        public ulong ExtendedRow;
        [FieldOffset(0)]
        public ulong BankGroup;
        [FieldOffset(0)]
        public ulong BankAddress;
        [FieldOffset(0)]
        public ulong ChipIdentification;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong ValidBits;
    }
}