using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EPROCESS_VALUES")]
    public sealed class EprocessValues : DynamicStructure
    {
        [Offset(0UL)]
        public ulong KernelTime { get => ReadHere<ulong>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(8UL)]
        public ulong UserTime { get => ReadHere<ulong>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(16UL)]
        public ulong ReadyTime { get => ReadHere<ulong>(nameof(ReadyTime)); set => WriteHere(nameof(ReadyTime), value); }

        [Offset(24UL)]
        public ulong CycleTime { get => ReadHere<ulong>(nameof(CycleTime)); set => WriteHere(nameof(CycleTime), value); }

        [Offset(32UL)]
        public ulong ContextSwitches { get => ReadHere<ulong>(nameof(ContextSwitches)); set => WriteHere(nameof(ContextSwitches), value); }

        [Offset(40UL)]
        public long ReadOperationCount { get => ReadHere<long>(nameof(ReadOperationCount)); set => WriteHere(nameof(ReadOperationCount), value); }

        [Offset(48UL)]
        public long WriteOperationCount { get => ReadHere<long>(nameof(WriteOperationCount)); set => WriteHere(nameof(WriteOperationCount), value); }

        [Offset(56UL)]
        public long OtherOperationCount { get => ReadHere<long>(nameof(OtherOperationCount)); set => WriteHere(nameof(OtherOperationCount), value); }

        [Offset(64UL)]
        public long ReadTransferCount { get => ReadHere<long>(nameof(ReadTransferCount)); set => WriteHere(nameof(ReadTransferCount), value); }

        [Offset(72UL)]
        public long WriteTransferCount { get => ReadHere<long>(nameof(WriteTransferCount)); set => WriteHere(nameof(WriteTransferCount), value); }

        [Offset(80UL)]
        public long OtherTransferCount { get => ReadHere<long>(nameof(OtherTransferCount)); set => WriteHere(nameof(OtherTransferCount), value); }

        [Offset(88UL)]
        public ulong KernelWaitTime { get => ReadHere<ulong>(nameof(KernelWaitTime)); set => WriteHere(nameof(KernelWaitTime), value); }

        [Offset(96UL)]
        public ulong UserWaitTime { get => ReadHere<ulong>(nameof(UserWaitTime)); set => WriteHere(nameof(UserWaitTime), value); }

        public EprocessValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EprocessValues>();
        }
    }
}