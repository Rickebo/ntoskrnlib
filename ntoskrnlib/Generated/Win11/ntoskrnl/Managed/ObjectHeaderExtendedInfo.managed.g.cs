using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_EXTENDED_INFO")]
    public sealed class ObjectHeaderExtendedInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Footer { get => ReadHere<IntPtr>(nameof(Footer)); set => WriteHere(nameof(Footer), value); }

        [Offset(8UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ObjectHeaderExtendedInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderExtendedInfo>();
        }
    }
}