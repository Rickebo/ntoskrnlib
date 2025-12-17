using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MMSUPPORT_FULL")]
    public sealed class MmsupportFull : DynamicStructure
    {
        [Offset(0UL)]
        public MmsupportInstance Instance { get => ReadStructure<MmsupportInstance>(nameof(Instance)); set => WriteStructure(nameof(Instance), value); }

        [Offset(192UL)]
        public MmsupportShared Shared { get => ReadStructure<MmsupportShared>(nameof(Shared)); set => WriteStructure(nameof(Shared), value); }

        public MmsupportFull(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsupportFull>();
        }
    }
}