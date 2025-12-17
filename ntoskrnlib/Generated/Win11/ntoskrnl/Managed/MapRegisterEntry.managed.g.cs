using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MAP_REGISTER_ENTRY")]
    public sealed class MapRegisterEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr MapRegister { get => ReadHere<IntPtr>(nameof(MapRegister)); set => WriteHere(nameof(MapRegister), value); }

        [Offset(8UL)]
        public byte WriteToDevice { get => ReadHere<byte>(nameof(WriteToDevice)); set => WriteHere(nameof(WriteToDevice), value); }

        public MapRegisterEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MapRegisterEntry>();
        }
    }
}