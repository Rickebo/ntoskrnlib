using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_PPM_PROFILE")]
    public sealed class PopPpmProfile : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Name { get => ReadHere<IntPtr>(nameof(Name)); set => WriteHere(nameof(Name), value); }

        [Offset(8UL)]
        public byte Id { get => ReadHere<byte>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(12UL)]
        public Guid Guid { get => ReadStructure<Guid>(nameof(Guid)); set => WriteStructure(nameof(Guid), value); }

        [Offset(28UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(32UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(40UL)]
        [Length(2)]
        public DynamicArray Settings { get => ReadStructure<DynamicArray>(nameof(Settings)); set => WriteStructure(nameof(Settings), value); }

        [Offset(1016UL)]
        public ulong StartTime { get => ReadHere<ulong>(nameof(StartTime)); set => WriteHere(nameof(StartTime), value); }

        [Offset(1024UL)]
        public ulong Count { get => ReadHere<ulong>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(1032UL)]
        public ulong MaxDuration { get => ReadHere<ulong>(nameof(MaxDuration)); set => WriteHere(nameof(MaxDuration), value); }

        [Offset(1040UL)]
        public ulong MinDuration { get => ReadHere<ulong>(nameof(MinDuration)); set => WriteHere(nameof(MinDuration), value); }

        [Offset(1048UL)]
        public ulong TotalDuration { get => ReadHere<ulong>(nameof(TotalDuration)); set => WriteHere(nameof(TotalDuration), value); }

        public PopPpmProfile(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopPpmProfile>();
        }
    }
}