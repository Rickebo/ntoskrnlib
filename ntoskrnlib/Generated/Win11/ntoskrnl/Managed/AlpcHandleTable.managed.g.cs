using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_HANDLE_TABLE")]
    public sealed class AlpcHandleTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Handles { get => ReadHere<IntPtr>(nameof(Handles)); set => WriteHere(nameof(Handles), value); }

        [Offset(8UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(16UL)]
        public ulong TotalHandles { get => ReadHere<ulong>(nameof(TotalHandles)); set => WriteHere(nameof(TotalHandles), value); }

        [Offset(24UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public AlpcHandleTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcHandleTable>();
        }
    }
}