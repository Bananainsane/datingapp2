using Microsoft.AspNetCore.Components.Server.Circuits;
using System.Diagnostics;

public class CircuitHandlerService : CircuitHandler
{
    public override Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Circuit opened");
        return base.OnCircuitOpenedAsync(circuit, cancellationToken);
    }

    public override Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Circuit closed");
        return base.OnCircuitClosedAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Connection down");
        return base.OnConnectionDownAsync(circuit, cancellationToken);
    }

    public override Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
    {
        Debug.WriteLine("Connection restored");
        return base.OnConnectionUpAsync(circuit, cancellationToken);
    }
}
