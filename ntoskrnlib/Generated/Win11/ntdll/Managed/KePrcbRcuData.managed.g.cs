using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KE_PRCB_RCU_DATA")]
    public sealed class KePrcbRcuData : DynamicStructure
    {
        [Offset(0UL)]
        public uint NestingLevel { get => ReadHere<uint>(nameof(NestingLevel)); set => WriteHere(nameof(NestingLevel), value); }

        [Offset(4UL)]
        public byte DispatchPin { get => ReadHere<byte>(nameof(DispatchPin)); set => WriteHere(nameof(DispatchPin), value); }

        [Offset(5UL)]
        public byte GracePeriodNeeded { get => ReadHere<byte>(nameof(GracePeriodNeeded)); set => WriteHere(nameof(GracePeriodNeeded), value); }

        [Offset(6UL)]
        public byte ExpediteReporting { get => ReadHere<byte>(nameof(ExpediteReporting)); set => WriteHere(nameof(ExpediteReporting), value); }

        [Offset(7UL)]
        public sbyte IdleState { get => ReadHere<sbyte>(nameof(IdleState)); set => WriteHere(nameof(IdleState), value); }

        [Offset(8UL)]
        public ulong GraceSequenceQuiescent { get => ReadHere<ulong>(nameof(GraceSequenceQuiescent)); set => WriteHere(nameof(GraceSequenceQuiescent), value); }

        [Offset(16UL)]
        public ulong GraceSequenceReported { get => ReadHere<ulong>(nameof(GraceSequenceReported)); set => WriteHere(nameof(GraceSequenceReported), value); }

        [Offset(24UL)]
        public IntPtr AwaitingCompletion { get => ReadHere<IntPtr>(nameof(AwaitingCompletion)); set => WriteHere(nameof(AwaitingCompletion), value); }

        public KePrcbRcuData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KePrcbRcuData>();
        }
    }
}