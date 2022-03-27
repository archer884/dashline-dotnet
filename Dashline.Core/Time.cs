namespace Dashline.Core;

public static class Time
{
    private static DateTimeOffset? _override = null;

    public static DateTimeOffset Now => _override ?? DateTimeOffset.UtcNow;

    public static void SetOverride(DateTimeOffset @override)
    {
        _override = @override;
    }

    public static void ClearOverride()
    {
        _override = null;
    }
}
