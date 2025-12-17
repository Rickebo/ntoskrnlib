using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_NT_TIB32")]
    public sealed class NtTIB32 : DynamicStructure
    {
        [Offset(0UL)]
        public uint ExceptionList { get => ReadHere<uint>(nameof(ExceptionList)); set => WriteHere(nameof(ExceptionList), value); }

        [Offset(4UL)]
        public uint StackBase { get => ReadHere<uint>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(8UL)]
        public uint StackLimit { get => ReadHere<uint>(nameof(StackLimit)); set => WriteHere(nameof(StackLimit), value); }

        [Offset(12UL)]
        public uint SubSystemTib { get => ReadHere<uint>(nameof(SubSystemTib)); set => WriteHere(nameof(SubSystemTib), value); }

        [Offset(16UL)]
        public uint FiberData { get => ReadHere<uint>(nameof(FiberData)); set => WriteHere(nameof(FiberData), value); }

        [Offset(16UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(20UL)]
        public uint ArbitraryUserPointer { get => ReadHere<uint>(nameof(ArbitraryUserPointer)); set => WriteHere(nameof(ArbitraryUserPointer), value); }

        [Offset(24UL)]
        public uint Self { get => ReadHere<uint>(nameof(Self)); set => WriteHere(nameof(Self), value); }

        public NtTIB32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtTIB32>();
        }
    }
}