using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_VETO_ENTRY")]
    public sealed class PpmVetoEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Link { get => ReadStructure<ListEntry>(nameof(Link)); set => WriteStructure(nameof(Link), value); }

        [Offset(16UL)]
        public uint VetoReason { get => ReadHere<uint>(nameof(VetoReason)); set => WriteHere(nameof(VetoReason), value); }

        [Offset(20UL)]
        public uint ReferenceCount { get => ReadHere<uint>(nameof(ReferenceCount)); set => WriteHere(nameof(ReferenceCount), value); }

        [Offset(24UL)]
        public ulong HitCount { get => ReadHere<ulong>(nameof(HitCount)); set => WriteHere(nameof(HitCount), value); }

        [Offset(32UL)]
        public ulong LastActivationTime { get => ReadHere<ulong>(nameof(LastActivationTime)); set => WriteHere(nameof(LastActivationTime), value); }

        [Offset(40UL)]
        public ulong TotalActiveTime { get => ReadHere<ulong>(nameof(TotalActiveTime)); set => WriteHere(nameof(TotalActiveTime), value); }

        [Offset(48UL)]
        public ulong CsActivationTime { get => ReadHere<ulong>(nameof(CsActivationTime)); set => WriteHere(nameof(CsActivationTime), value); }

        [Offset(56UL)]
        public ulong CsActiveTime { get => ReadHere<ulong>(nameof(CsActiveTime)); set => WriteHere(nameof(CsActiveTime), value); }

        public PpmVetoEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmVetoEntry>();
        }
    }
}