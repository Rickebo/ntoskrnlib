using ntoskrnlib.Abstractions;
using ntoskrnlib.Symbols;

namespace ntoskrnlib.Services;

internal sealed class SymbolSessionFactory : ISymbolSessionFactory
{
    public SymbolSession Create(string modulePath, string? symbolPath = null)
        => new SymbolSession(modulePath, symbolPath);
}

