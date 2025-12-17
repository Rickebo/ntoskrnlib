using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_FLAGS")]
    public sealed class _DEVICE_FLAGS : DynamicStructure
    {
        public uint Failed { get; }
        public uint ReadOnly { get; }
        public uint Removable { get; }
        public uint ConsoleIn { get; }
        public uint ConsoleOut { get; }
        public uint Input { get; }
        public uint Output { get; }

        public _DEVICE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_FLAGS.Failed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.ReadOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.Removable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.ConsoleIn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.ConsoleOut),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.Input),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_FLAGS.Output),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DEVICE_FLAGS>((mem, ptr) => new _DEVICE_FLAGS(mem, ptr), offsets);
        }
    }
}