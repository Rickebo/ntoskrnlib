using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_SCOPE_INSTANCE")]
    public sealed class WnfScopeInstance : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public ExRundownRef RunRef { get => ReadStructure<ExRundownRef>(nameof(RunRef)); set => WriteStructure(nameof(RunRef), value); }

        [Offset(16UL)]
        public uint DataScope { get => ReadHere<uint>(nameof(DataScope)); set => WriteHere(nameof(DataScope), value); }

        [Offset(20UL)]
        public uint InstanceIdSize { get => ReadHere<uint>(nameof(InstanceIdSize)); set => WriteHere(nameof(InstanceIdSize), value); }

        [Offset(24UL)]
        public IntPtr InstanceIdData { get => ReadHere<IntPtr>(nameof(InstanceIdData)); set => WriteHere(nameof(InstanceIdData), value); }

        [Offset(32UL)]
        public ListEntry ResolverListEntry { get => ReadStructure<ListEntry>(nameof(ResolverListEntry)); set => WriteStructure(nameof(ResolverListEntry), value); }

        [Offset(48UL)]
        public WnfLock NameSetLock { get => ReadStructure<WnfLock>(nameof(NameSetLock)); set => WriteStructure(nameof(NameSetLock), value); }

        [Offset(56UL)]
        public RtlAvlTree NameSet { get => ReadStructure<RtlAvlTree>(nameof(NameSet)); set => WriteStructure(nameof(NameSet), value); }

        [Offset(64UL)]
        public IntPtr PermanentDataStore { get => ReadHere<IntPtr>(nameof(PermanentDataStore)); set => WriteHere(nameof(PermanentDataStore), value); }

        [Offset(72UL)]
        public IntPtr VolatilePermanentDataStore { get => ReadHere<IntPtr>(nameof(VolatilePermanentDataStore)); set => WriteHere(nameof(VolatilePermanentDataStore), value); }

        public WnfScopeInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfScopeInstance>();
        }
    }
}