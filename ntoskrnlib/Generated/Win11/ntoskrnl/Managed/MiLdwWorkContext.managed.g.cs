using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_LDW_WORK_CONTEXT")]
    public sealed class MiLdwWorkContext : DynamicStructure
    {
        [Offset(0UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(32UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(40UL)]
        public int ErrorStatus { get => ReadHere<int>(nameof(ErrorStatus)); set => WriteHere(nameof(ErrorStatus), value); }

        [Offset(44UL)]
        public int Active { get => ReadHere<int>(nameof(Active)); set => WriteHere(nameof(Active), value); }

        [Offset(48UL)]
        public byte FreeWhenDone { get => ReadHere<byte>(nameof(FreeWhenDone)); set => WriteHere(nameof(FreeWhenDone), value); }

        public MiLdwWorkContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiLdwWorkContext>();
        }
    }
}