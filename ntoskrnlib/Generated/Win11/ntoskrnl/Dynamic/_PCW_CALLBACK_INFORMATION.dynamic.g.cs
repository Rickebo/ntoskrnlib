using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_CALLBACK_INFORMATION")]
    public sealed class _PCW_CALLBACK_INFORMATION : DynamicStructure
    {
        public _PCW_COUNTER_INFORMATION AddCounter { get; }
        public _PCW_COUNTER_INFORMATION RemoveCounter { get; }
        public _PCW_MASK_INFORMATION EnumerateInstances { get; }
        public _PCW_MASK_INFORMATION CollectData { get; }

        public _PCW_CALLBACK_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_CALLBACK_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_CALLBACK_INFORMATION.AddCounter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_CALLBACK_INFORMATION.RemoveCounter),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_CALLBACK_INFORMATION.EnumerateInstances),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_CALLBACK_INFORMATION.CollectData),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PCW_CALLBACK_INFORMATION>((mem, ptr) => new _PCW_CALLBACK_INFORMATION(mem, ptr), offsets);
        }
    }
}