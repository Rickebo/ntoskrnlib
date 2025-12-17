using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!POWER_ACTION_POLICY")]
    public sealed class PowerActionPolicy : DynamicStructure
    {
        [Offset(0UL)]
        public uint Action { get => ReadHere<uint>(nameof(Action)); set => WriteHere(nameof(Action), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(8UL)]
        public uint EventCode { get => ReadHere<uint>(nameof(EventCode)); set => WriteHere(nameof(EventCode), value); }

        public PowerActionPolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerActionPolicy>();
        }
    }
}