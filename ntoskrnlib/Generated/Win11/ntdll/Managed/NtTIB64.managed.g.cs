using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_NT_TIB64")]
    public sealed class NtTIB64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong ExceptionList { get => ReadHere<ulong>(nameof(ExceptionList)); set => WriteHere(nameof(ExceptionList), value); }

        [Offset(8UL)]
        public ulong StackBase { get => ReadHere<ulong>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(16UL)]
        public ulong StackLimit { get => ReadHere<ulong>(nameof(StackLimit)); set => WriteHere(nameof(StackLimit), value); }

        [Offset(24UL)]
        public ulong SubSystemTib { get => ReadHere<ulong>(nameof(SubSystemTib)); set => WriteHere(nameof(SubSystemTib), value); }

        [Offset(32UL)]
        public ulong FiberData { get => ReadHere<ulong>(nameof(FiberData)); set => WriteHere(nameof(FiberData), value); }

        [Offset(32UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(40UL)]
        public ulong ArbitraryUserPointer { get => ReadHere<ulong>(nameof(ArbitraryUserPointer)); set => WriteHere(nameof(ArbitraryUserPointer), value); }

        [Offset(48UL)]
        public ulong Self { get => ReadHere<ulong>(nameof(Self)); set => WriteHere(nameof(Self), value); }

        public NtTIB64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtTIB64>();
        }
    }
}