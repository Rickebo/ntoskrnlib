using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_COMPLETE_IDLE_STATE")]
    public sealed class PepWorkCompleteIdleState : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DeviceHandle { get => ReadHere<IntPtr>(nameof(DeviceHandle)); set => WriteHere(nameof(DeviceHandle), value); }

        [Offset(8UL)]
        public uint Component { get => ReadHere<uint>(nameof(Component)); set => WriteHere(nameof(Component), value); }

        public PepWorkCompleteIdleState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkCompleteIdleState>();
        }
    }
}