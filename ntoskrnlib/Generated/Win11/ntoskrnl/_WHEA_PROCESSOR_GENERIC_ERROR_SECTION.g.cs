#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 192)]
    public partial struct _WHEA_PROCESSOR_GENERIC_ERROR_SECTION
    {
        [FieldOffset(0)]
        public _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS ValidBits;
        [FieldOffset(8)]
        public byte ProcessorType;
        [FieldOffset(9)]
        public byte InstructionSet;
        [FieldOffset(10)]
        public byte ErrorType;
        [FieldOffset(11)]
        public byte Operation;
        [FieldOffset(12)]
        public byte Flags;
        [FieldOffset(13)]
        public byte Level;
        [FieldOffset(14)]
        public ushort Reserved;
        [FieldOffset(16)]
        public ulong CPUVersion;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] CPUBrandString;
        [FieldOffset(152)]
        public ulong ProcessorId;
        [FieldOffset(160)]
        public ulong TargetAddress;
        [FieldOffset(168)]
        public ulong RequesterId;
        [FieldOffset(176)]
        public ulong ResponderId;
        [FieldOffset(184)]
        public ulong InstructionPointer;
    }
}