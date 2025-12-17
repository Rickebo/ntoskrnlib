using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OBJECT_DUMP_CONTROL")]
    public sealed class ObjectDumpControl : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Stream { get => ReadHere<IntPtr>(nameof(Stream)); set => WriteHere(nameof(Stream), value); }

        [Offset(8UL)]
        public uint Detail { get => ReadHere<uint>(nameof(Detail)); set => WriteHere(nameof(Detail), value); }

        public ObjectDumpControl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectDumpControl>();
        }
    }
}