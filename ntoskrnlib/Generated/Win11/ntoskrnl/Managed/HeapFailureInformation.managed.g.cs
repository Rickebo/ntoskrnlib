using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HEAP_FAILURE_INFORMATION")]
    public sealed class HeapFailureInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint StructureSize { get => ReadHere<uint>(nameof(StructureSize)); set => WriteHere(nameof(StructureSize), value); }

        [Offset(8UL)]
        public uint FailureType { get => ReadHere<uint>(nameof(FailureType)); set => WriteHere(nameof(FailureType), value); }

        [Offset(16UL)]
        public IntPtr HeapAddress { get => ReadHere<IntPtr>(nameof(HeapAddress)); set => WriteHere(nameof(HeapAddress), value); }

        [Offset(24UL)]
        public IntPtr Address { get => ReadHere<IntPtr>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(32UL)]
        public IntPtr Param1 { get => ReadHere<IntPtr>(nameof(Param1)); set => WriteHere(nameof(Param1), value); }

        [Offset(40UL)]
        public IntPtr Param2 { get => ReadHere<IntPtr>(nameof(Param2)); set => WriteHere(nameof(Param2), value); }

        [Offset(48UL)]
        public IntPtr Param3 { get => ReadHere<IntPtr>(nameof(Param3)); set => WriteHere(nameof(Param3), value); }

        [Offset(56UL)]
        public IntPtr PreviousBlock { get => ReadHere<IntPtr>(nameof(PreviousBlock)); set => WriteHere(nameof(PreviousBlock), value); }

        [Offset(64UL)]
        public IntPtr NextBlock { get => ReadHere<IntPtr>(nameof(NextBlock)); set => WriteHere(nameof(NextBlock), value); }

        [Offset(72UL)]
        public FakeHeapEntry ExpectedDecodedEntry { get => ReadStructure<FakeHeapEntry>(nameof(ExpectedDecodedEntry)); set => WriteStructure(nameof(ExpectedDecodedEntry), value); }

        [Offset(88UL)]
        [Length(32)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        [Offset(344UL)]
        public byte HeapMajorVersion { get => ReadHere<byte>(nameof(HeapMajorVersion)); set => WriteHere(nameof(HeapMajorVersion), value); }

        [Offset(345UL)]
        public byte HeapMinorVersion { get => ReadHere<byte>(nameof(HeapMinorVersion)); set => WriteHere(nameof(HeapMinorVersion), value); }

        [Offset(352UL)]
        public ExceptionRecord ExceptionRecord { get => ReadStructure<ExceptionRecord>(nameof(ExceptionRecord)); set => WriteStructure(nameof(ExceptionRecord), value); }

        [Offset(512UL)]
        public Context ContextRecord { get => ReadStructure<Context>(nameof(ContextRecord)); set => WriteStructure(nameof(ContextRecord), value); }

        public HeapFailureInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HeapFailureInformation>();
        }
    }
}