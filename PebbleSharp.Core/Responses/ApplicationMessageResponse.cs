using System.Diagnostics.CodeAnalysis;

namespace PebbleSharp.Core.Responses;

[Endpoint(Endpoint.ApplicationMessage)]
[Experimental("CS000")]
public class ApplicationMessageResponse : ResponseBase
{
    public UUID? TargetUUID;

    public Dictionary<string, uint> ParsdData { get; private set; }

    protected override void Load(byte[] payload)
    {
        if (payload == null || payload.Length == 0)
        {
            SetError("Payload is empty or null");
            return;
        }

        ParsdData = new Dictionary<string, uint>();
    }
}