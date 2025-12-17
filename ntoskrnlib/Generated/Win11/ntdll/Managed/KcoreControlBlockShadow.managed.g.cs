using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KCORE_CONTROL_BLOCK_SHADOW")]
    public sealed class KcoreControlBlockShadow : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public ulong CurrentIsolationDomain { get => ReadHere<ulong>(nameof(CurrentIsolationDomain)); set => WriteHere(nameof(CurrentIsolationDomain), value); }

        [Offset(16UL)]
        public ulong NextIsolationDomain { get => ReadHere<ulong>(nameof(NextIsolationDomain)); set => WriteHere(nameof(NextIsolationDomain), value); }

        [Offset(24UL)]
        public byte TotalProcessors { get => ReadHere<byte>(nameof(TotalProcessors)); set => WriteHere(nameof(TotalProcessors), value); }

        [Offset(25UL)]
        public byte IdleProcessors { get => ReadHere<byte>(nameof(IdleProcessors)); set => WriteHere(nameof(IdleProcessors), value); }

        [Offset(26UL)]
        public byte NewDomainProcessors { get => ReadHere<byte>(nameof(NewDomainProcessors)); set => WriteHere(nameof(NewDomainProcessors), value); }

        [Offset(27UL)]
        public byte Spare { get => ReadHere<byte>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        [Offset(28UL)]
        [Length(4)]
        public DynamicArray ProcessorStates { get => ReadStructure<DynamicArray>(nameof(ProcessorStates)); set => WriteStructure(nameof(ProcessorStates), value); }

        [Offset(32UL)]
        [Length(4)]
        public DynamicArray InterruptTargets { get => ReadStructure<DynamicArray>(nameof(InterruptTargets)); set => WriteStructure(nameof(InterruptTargets), value); }

        public KcoreControlBlockShadow(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KcoreControlBlockShadow>();
        }
    }
}