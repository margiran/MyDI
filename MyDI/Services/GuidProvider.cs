namespace MyDI.Services;

public class GuidProvider : IGuidProvider
{
    private readonly IGuidGenerator _guidGenerator;
    public GuidProvider(IGuidGenerator guidGenerator)
    {
        _guidGenerator = guidGenerator;
        guid = _guidGenerator.GeneratedGuid;
    }
    private Guid guid { get; } 

    public Guid GetGuid()
    {
        return guid;
    }

}
