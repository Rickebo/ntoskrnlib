using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_PROCESS_INFO")]
    public sealed class ObjectHeaderProcessInfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ExclusiveProcess { get => ReadHere<IntPtr>(nameof(ExclusiveProcess)); set => WriteHere(nameof(ExclusiveProcess), value); }

        [Offset(8UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ObjectHeaderProcessInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderProcessInfo>();
        }
    }
}