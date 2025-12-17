using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KDPC")]
    public sealed class Kdpc : DynamicStructure
    {
        [Offset(0UL)]
        public uint TargetInfoAsUlong { get => ReadHere<uint>(nameof(TargetInfoAsUlong)); set => WriteHere(nameof(TargetInfoAsUlong), value); }

        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Importance { get => ReadHere<byte>(nameof(Importance)); set => WriteHere(nameof(Importance), value); }

        [Offset(2UL)]
        public ushort Number { get => ReadHere<ushort>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        [Offset(8UL)]
        public SingleListEntry DpcListEntry { get => ReadStructure<SingleListEntry>(nameof(DpcListEntry)); set => WriteStructure(nameof(DpcListEntry), value); }

        [Offset(16UL)]
        public ulong ProcessorHistory { get => ReadHere<ulong>(nameof(ProcessorHistory)); set => WriteHere(nameof(ProcessorHistory), value); }

        [Offset(24UL)]
        public IntPtr DeferredRoutine { get => ReadHere<IntPtr>(nameof(DeferredRoutine)); set => WriteHere(nameof(DeferredRoutine), value); }

        [Offset(32UL)]
        public IntPtr DeferredContext { get => ReadHere<IntPtr>(nameof(DeferredContext)); set => WriteHere(nameof(DeferredContext), value); }

        [Offset(40UL)]
        public IntPtr SystemArgument1 { get => ReadHere<IntPtr>(nameof(SystemArgument1)); set => WriteHere(nameof(SystemArgument1), value); }

        [Offset(48UL)]
        public IntPtr SystemArgument2 { get => ReadHere<IntPtr>(nameof(SystemArgument2)); set => WriteHere(nameof(SystemArgument2), value); }

        [Offset(56UL)]
        public IntPtr DpcData { get => ReadHere<IntPtr>(nameof(DpcData)); set => WriteHere(nameof(DpcData), value); }

        public Kdpc(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Kdpc>();
        }
    }
}