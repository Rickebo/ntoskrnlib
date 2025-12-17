using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_WORK_QUEUE_MANAGER")]
    public sealed class _EX_WORK_QUEUE_MANAGER : DynamicStructure
    {
        public IntPtr Partition { get; }
        public IntPtr Node { get; }
        public _KEVENT Event { get; }
        public _KTIMER DeadlockTimer { get; }
        public _KEVENT ReaperEvent { get; }
        public _KTIMER2 ReaperTimer { get; }
        public IntPtr ThreadHandle { get; }
        public uint ExitThread { get; }
        public ushort ThreadSeed { get; }

        public _EX_WORK_QUEUE_MANAGER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_WORK_QUEUE_MANAGER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.Partition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.Node),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.Event),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.DeadlockTimer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.ReaperEvent),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.ReaperTimer),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.ThreadHandle),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.ExitThread),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_EX_WORK_QUEUE_MANAGER.ThreadSeed),
                    new ulong[]
                    {
                        276UL
                    }
                }
            };
            Register<_EX_WORK_QUEUE_MANAGER>((mem, ptr) => new _EX_WORK_QUEUE_MANAGER(mem, ptr), offsets);
        }
    }
}