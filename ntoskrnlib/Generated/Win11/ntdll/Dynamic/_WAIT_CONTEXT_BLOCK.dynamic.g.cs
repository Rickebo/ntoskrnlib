using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WAIT_CONTEXT_BLOCK")]
    public sealed class _WAIT_CONTEXT_BLOCK : DynamicStructure
    {
        public _KDEVICE_QUEUE_ENTRY WaitQueueEntry { get; }
        public _LIST_ENTRY DmaWaitEntry { get; }
        public uint NumberOfChannels { get; }
        public uint SyncCallback { get; }
        public uint DmaContext { get; }
        public uint ZeroMapRegisters { get; }
        public uint Reserved { get; }
        public uint NumberOfRemapPages { get; }
        public IntPtr DeviceRoutine { get; }
        public IntPtr DeviceContext { get; }
        public uint NumberOfMapRegisters { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr CurrentIrp { get; }
        public IntPtr BufferChainingDpc { get; }

        public _WAIT_CONTEXT_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WAIT_CONTEXT_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WAIT_CONTEXT_BLOCK.WaitQueueEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.DmaWaitEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.NumberOfChannels),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.SyncCallback),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.DmaContext),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.ZeroMapRegisters),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.Reserved),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.NumberOfRemapPages),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.DeviceRoutine),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.DeviceContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.NumberOfMapRegisters),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.DeviceObject),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.CurrentIrp),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WAIT_CONTEXT_BLOCK.BufferChainingDpc),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_WAIT_CONTEXT_BLOCK>((mem, ptr) => new _WAIT_CONTEXT_BLOCK(mem, ptr), offsets);
        }
    }
}