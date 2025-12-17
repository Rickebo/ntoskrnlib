using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_RECORD_WRAPPER")]
    public sealed class _WHEAP_ERROR_RECORD_WRAPPER : DynamicStructure
    {
        public _LIST_ENTRY WorkEntry { get; }
        public uint Length { get; }
        public uint ProcessorNumber { get; }
        public _WHEAP_ERROR_RECORD_WRAPPER_FLAGS Flags { get; }
        public int InUse { get; }
        public IntPtr ErrorSource { get; }
        public _WHEA_ERROR_RECORD ErrorRecord { get; }

        public _WHEAP_ERROR_RECORD_WRAPPER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_ERROR_RECORD_WRAPPER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.WorkEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.Length),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.ProcessorNumber),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.InUse),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.ErrorSource),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER.ErrorRecord),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_WHEAP_ERROR_RECORD_WRAPPER>((mem, ptr) => new _WHEAP_ERROR_RECORD_WRAPPER(mem, ptr), offsets);
        }
    }
}