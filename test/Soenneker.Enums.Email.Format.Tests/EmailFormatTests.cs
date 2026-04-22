using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.Email.Format.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailFormatTests : HostedUnitTest
{
    public EmailFormatTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
