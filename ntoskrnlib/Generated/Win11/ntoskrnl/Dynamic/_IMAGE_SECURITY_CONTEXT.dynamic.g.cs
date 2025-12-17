using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IMAGE_SECURITY_CONTEXT")]
    public sealed class _IMAGE_SECURITY_CONTEXT : DynamicStructure
    {
        public IntPtr PageHashes { get; }
        public ulong Value { get; }
        public ulong SecurityBeingCreated { get; }
        public ulong SecurityMandatory { get; }
        public ulong PageHashPointer { get; }

        public _IMAGE_SECURITY_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_SECURITY_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_SECURITY_CONTEXT.PageHashes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_SECURITY_CONTEXT.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_SECURITY_CONTEXT.SecurityBeingCreated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_SECURITY_CONTEXT.SecurityMandatory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_SECURITY_CONTEXT.PageHashPointer),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IMAGE_SECURITY_CONTEXT>((mem, ptr) => new _IMAGE_SECURITY_CONTEXT(mem, ptr), offsets);
        }
    }
}