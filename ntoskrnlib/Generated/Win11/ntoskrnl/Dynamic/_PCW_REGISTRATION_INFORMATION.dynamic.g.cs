using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PCW_REGISTRATION_INFORMATION")]
    public sealed class _PCW_REGISTRATION_INFORMATION : DynamicStructure
    {
        public uint Version { get; }
        public IntPtr Name { get; }
        public uint CounterCount { get; }
        public IntPtr Counters { get; }
        public IntPtr Callback { get; }
        public IntPtr CallbackContext { get; }
        public uint Flags { get; }

        public _PCW_REGISTRATION_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PCW_REGISTRATION_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.Name),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.CounterCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.Counters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.Callback),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.CallbackContext),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PCW_REGISTRATION_INFORMATION.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_PCW_REGISTRATION_INFORMATION>((mem, ptr) => new _PCW_REGISTRATION_INFORMATION(mem, ptr), offsets);
        }
    }
}