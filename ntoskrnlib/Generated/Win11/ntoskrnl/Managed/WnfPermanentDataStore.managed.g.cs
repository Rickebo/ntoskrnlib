using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_PERMANENT_DATA_STORE")]
    public sealed class WnfPermanentDataStore : DynamicStructure
    {
        [Offset(0UL)]
        public WnfNodeHeader Header { get => ReadStructure<WnfNodeHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public WnfLock Lock { get => ReadStructure<WnfLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(16UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        [Offset(24UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(40UL)]
        public uint DataScopeType { get => ReadHere<uint>(nameof(DataScopeType)); set => WriteHere(nameof(DataScopeType), value); }

        [Offset(44UL)]
        public uint ScopeInstanceIdSize { get => ReadHere<uint>(nameof(ScopeInstanceIdSize)); set => WriteHere(nameof(ScopeInstanceIdSize), value); }

        public WnfPermanentDataStore(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfPermanentDataStore>();
        }
    }
}