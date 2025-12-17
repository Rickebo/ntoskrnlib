using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EXHANDLE")]
    public sealed class Exhandle : DynamicStructure
    {
        [Offset(0UL)]
        public uint TagBits { get => ReadHere<uint>(nameof(TagBits)); set => WriteHere(nameof(TagBits), value); }

        [Offset(0UL)]
        public uint Index { get => ReadHere<uint>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(0UL)]
        public IntPtr GenericHandleOverlay { get => ReadHere<IntPtr>(nameof(GenericHandleOverlay)); set => WriteHere(nameof(GenericHandleOverlay), value); }

        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        public Exhandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Exhandle>();
        }
    }
}