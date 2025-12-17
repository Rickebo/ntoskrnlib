using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_STACK_LOCATION")]
    public sealed class _IO_STACK_LOCATION : DynamicStructure
    {
        public byte MajorFunction { get; }
        public byte MinorFunction { get; }
        public byte Flags { get; }
        public byte Control { get; }
        public _unnamed_tag_ Parameters { get; }
        public IntPtr DeviceObject { get; }
        public IntPtr FileObject { get; }
        public IntPtr CompletionRoutine { get; }
        public IntPtr Context { get; }

        public _IO_STACK_LOCATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_STACK_LOCATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_STACK_LOCATION.MajorFunction),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.MinorFunction),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.Control),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.Parameters),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.DeviceObject),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.FileObject),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.CompletionRoutine),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IO_STACK_LOCATION.Context),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_IO_STACK_LOCATION>((mem, ptr) => new _IO_STACK_LOCATION(mem, ptr), offsets);
        }
    }
}