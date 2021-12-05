using System;
namespace MyDI.Services;

public class GuidGenerator : IGuidGenerator
{
    public Guid GeneratedGuid { get; } = Guid.NewGuid();
}
