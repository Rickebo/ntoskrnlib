#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _WHEA_PROCESSOR_GENERIC_ERROR_SECTION_VALIDBITS
    {
        [FieldOffset(0)]
        public ulong ProcessorType;
        [FieldOffset(0)]
        public ulong InstructionSet;
        [FieldOffset(0)]
        public ulong ErrorType;
        [FieldOffset(0)]
        public ulong Operation;
        [FieldOffset(0)]
        public ulong Flags;
        [FieldOffset(0)]
        public ulong Level;
        [FieldOffset(0)]
        public ulong CPUVersion;
        [FieldOffset(0)]
        public ulong CPUBrandString;
        [FieldOffset(0)]
        public ulong ProcessorId;
        [FieldOffset(0)]
        public ulong TargetAddress;
        [FieldOffset(0)]
        public ulong RequesterId;
        [FieldOffset(0)]
        public ulong ResponderId;
        [FieldOffset(0)]
        public ulong InstructionPointer;
        [FieldOffset(0)]
        public ulong NativeModelId;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong ValidBits;
    }
}