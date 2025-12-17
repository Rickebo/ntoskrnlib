using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_HANDLE_TRACE_DB_ENTRY")]
    public sealed class HandleTraceDbEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ClientId ClientId { get => ReadStructure<ClientId>(nameof(ClientId)); set => WriteStructure(nameof(ClientId), value); }

        [Offset(16UL)]
        public IntPtr Handle { get => ReadHere<IntPtr>(nameof(Handle)); set => WriteHere(nameof(Handle), value); }

        [Offset(24UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(32UL)]
        [Length(16)]
        public DynamicArray StackTrace { get => ReadStructure<DynamicArray>(nameof(StackTrace)); set => WriteStructure(nameof(StackTrace), value); }

        public HandleTraceDbEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HandleTraceDbEntry>();
        }
    }
}