using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_NT_TIB")]
    public sealed class NtTib : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ExceptionList { get => ReadHere<IntPtr>(nameof(ExceptionList)); set => WriteHere(nameof(ExceptionList), value); }

        [Offset(8UL)]
        public IntPtr StackBase { get => ReadHere<IntPtr>(nameof(StackBase)); set => WriteHere(nameof(StackBase), value); }

        [Offset(16UL)]
        public IntPtr StackLimit { get => ReadHere<IntPtr>(nameof(StackLimit)); set => WriteHere(nameof(StackLimit), value); }

        [Offset(24UL)]
        public IntPtr SubSystemTib { get => ReadHere<IntPtr>(nameof(SubSystemTib)); set => WriteHere(nameof(SubSystemTib), value); }

        [Offset(32UL)]
        public IntPtr FiberData { get => ReadHere<IntPtr>(nameof(FiberData)); set => WriteHere(nameof(FiberData), value); }

        [Offset(32UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(40UL)]
        public IntPtr ArbitraryUserPointer { get => ReadHere<IntPtr>(nameof(ArbitraryUserPointer)); set => WriteHere(nameof(ArbitraryUserPointer), value); }

        [Offset(48UL)]
        public IntPtr Self { get => ReadHere<IntPtr>(nameof(Self)); set => WriteHere(nameof(Self), value); }

        public NtTib(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtTib>();
        }
    }
}