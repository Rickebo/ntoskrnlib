using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_WORK")]
    public sealed class TpWork : DynamicStructure
    {
        [Offset(0UL)]
        public TppCleanupGroupMember CleanupGroupMember { get => ReadStructure<TppCleanupGroupMember>(nameof(CleanupGroupMember)); set => WriteStructure(nameof(CleanupGroupMember), value); }

        [Offset(200UL)]
        public TpTask Task { get => ReadStructure<TpTask>(nameof(Task)); set => WriteStructure(nameof(Task), value); }

        [Offset(232UL)]
        public TppWorkState WorkState { get => ReadStructure<TppWorkState>(nameof(WorkState)); set => WriteStructure(nameof(WorkState), value); }

        public TpWork(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpWork>();
        }
    }
}