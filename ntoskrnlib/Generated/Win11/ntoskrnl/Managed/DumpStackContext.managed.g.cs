using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DUMP_STACK_CONTEXT")]
    public sealed class DumpStackContext : DynamicStructure
    {
        [Offset(0UL)]
        public DumpInitializationContext Init { get => ReadStructure<DumpInitializationContext>(nameof(Init)); set => WriteStructure(nameof(Init), value); }

        [Offset(264UL)]
        public LargeInteger PartitionOffset { get => ReadStructure<LargeInteger>(nameof(PartitionOffset)); set => WriteStructure(nameof(PartitionOffset), value); }

        [Offset(272UL)]
        public IntPtr DumpPointers { get => ReadHere<IntPtr>(nameof(DumpPointers)); set => WriteHere(nameof(DumpPointers), value); }

        [Offset(272UL)]
        public IntPtr StorageInfo { get => ReadHere<IntPtr>(nameof(StorageInfo)); set => WriteHere(nameof(StorageInfo), value); }

        [Offset(280UL)]
        public byte UseStorageInfo { get => ReadHere<byte>(nameof(UseStorageInfo)); set => WriteHere(nameof(UseStorageInfo), value); }

        [Offset(284UL)]
        public uint PointersLength { get => ReadHere<uint>(nameof(PointersLength)); set => WriteHere(nameof(PointersLength), value); }

        [Offset(288UL)]
        public IntPtr ModulePrefix { get => ReadHere<IntPtr>(nameof(ModulePrefix)); set => WriteHere(nameof(ModulePrefix), value); }

        [Offset(296UL)]
        public ListEntry DriverList { get => ReadStructure<ListEntry>(nameof(DriverList)); set => WriteStructure(nameof(DriverList), value); }

        [Offset(312UL)]
        public String InitMsg { get => ReadStructure<String>(nameof(InitMsg)); set => WriteStructure(nameof(InitMsg), value); }

        [Offset(328UL)]
        public String ProgMsg { get => ReadStructure<String>(nameof(ProgMsg)); set => WriteStructure(nameof(ProgMsg), value); }

        [Offset(344UL)]
        public String DoneMsg { get => ReadStructure<String>(nameof(DoneMsg)); set => WriteStructure(nameof(DoneMsg), value); }

        [Offset(360UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(368UL)]
        public uint UsageType { get => ReadHere<uint>(nameof(UsageType)); set => WriteHere(nameof(UsageType), value); }

        public DumpStackContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DumpStackContext>();
        }
    }
}