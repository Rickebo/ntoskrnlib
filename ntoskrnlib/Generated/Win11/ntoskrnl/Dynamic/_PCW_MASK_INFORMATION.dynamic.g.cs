using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_MASK_INFORMATION")]
    public sealed class _PCW_MASK_INFORMATION : DynamicStructure
    {
        public ulong CounterMask { get; }
        public IntPtr InstanceMask { get; }
        public uint InstanceId { get; }
        public byte CollectMultiple { get; }
        public IntPtr Buffer { get; }
        public IntPtr CancelEvent { get; }

        public _PCW_MASK_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_MASK_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_MASK_INFORMATION.CounterMask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_MASK_INFORMATION.InstanceMask),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PCW_MASK_INFORMATION.InstanceId),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PCW_MASK_INFORMATION.CollectMultiple),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_PCW_MASK_INFORMATION.Buffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PCW_MASK_INFORMATION.CancelEvent),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PCW_MASK_INFORMATION>((mem, ptr) => new _PCW_MASK_INFORMATION(mem, ptr), offsets);
        }
    }
}