using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ACTIVATION_CONTEXT_DATA")]
    public sealed class ActivationContextData : DynamicStructure
    {
        [Offset(0UL)]
        public uint Magic { get => ReadHere<uint>(nameof(Magic)); set => WriteHere(nameof(Magic), value); }

        [Offset(4UL)]
        public uint HeaderSize { get => ReadHere<uint>(nameof(HeaderSize)); set => WriteHere(nameof(HeaderSize), value); }

        [Offset(8UL)]
        public uint FormatVersion { get => ReadHere<uint>(nameof(FormatVersion)); set => WriteHere(nameof(FormatVersion), value); }

        [Offset(12UL)]
        public uint TotalSize { get => ReadHere<uint>(nameof(TotalSize)); set => WriteHere(nameof(TotalSize), value); }

        [Offset(16UL)]
        public uint DefaultTocOffset { get => ReadHere<uint>(nameof(DefaultTocOffset)); set => WriteHere(nameof(DefaultTocOffset), value); }

        [Offset(20UL)]
        public uint ExtendedTocOffset { get => ReadHere<uint>(nameof(ExtendedTocOffset)); set => WriteHere(nameof(ExtendedTocOffset), value); }

        [Offset(24UL)]
        public uint AssemblyRosterOffset { get => ReadHere<uint>(nameof(AssemblyRosterOffset)); set => WriteHere(nameof(AssemblyRosterOffset), value); }

        [Offset(28UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public ActivationContextData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ActivationContextData>();
        }
    }
}