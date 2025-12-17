using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_QUERY_REGISTRY_TABLE")]
    public sealed class RtlQueryRegistryTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr QueryRoutine { get => ReadHere<IntPtr>(nameof(QueryRoutine)); set => WriteHere(nameof(QueryRoutine), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(16UL)]
        public IntPtr Name { get => ReadHere<IntPtr>(nameof(Name)); set => WriteHere(nameof(Name), value); }

        [Offset(24UL)]
        public IntPtr EntryContext { get => ReadHere<IntPtr>(nameof(EntryContext)); set => WriteHere(nameof(EntryContext), value); }

        [Offset(32UL)]
        public uint DefaultType { get => ReadHere<uint>(nameof(DefaultType)); set => WriteHere(nameof(DefaultType), value); }

        [Offset(40UL)]
        public IntPtr DefaultData { get => ReadHere<IntPtr>(nameof(DefaultData)); set => WriteHere(nameof(DefaultData), value); }

        [Offset(48UL)]
        public uint DefaultLength { get => ReadHere<uint>(nameof(DefaultLength)); set => WriteHere(nameof(DefaultLength), value); }

        public RtlQueryRegistryTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlQueryRegistryTable>();
        }
    }
}