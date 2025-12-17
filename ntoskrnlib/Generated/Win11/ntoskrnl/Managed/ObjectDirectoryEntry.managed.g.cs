using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_DIRECTORY_ENTRY")]
    public sealed class ObjectDirectoryEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ChainLink { get => ReadHere<IntPtr>(nameof(ChainLink)); set => WriteHere(nameof(ChainLink), value); }

        [Offset(8UL)]
        public IntPtr Object { get => ReadHere<IntPtr>(nameof(Object)); set => WriteHere(nameof(Object), value); }

        [Offset(16UL)]
        public uint HashValue { get => ReadHere<uint>(nameof(HashValue)); set => WriteHere(nameof(HashValue), value); }

        public ObjectDirectoryEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectDirectoryEntry>();
        }
    }
}