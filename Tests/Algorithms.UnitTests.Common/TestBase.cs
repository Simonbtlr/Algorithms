using System;
using AutoFixture;

namespace Algorithms.UnitTests.Common;

public abstract class TestBase : IDisposable
{
    protected readonly Fixture Fixture;

    protected TestBase()
    {
        Fixture = new Fixture();
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}