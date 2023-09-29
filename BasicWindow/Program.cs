using SharpEngine.Core;

namespace BasicWindow;

internal static class Program
{
    private static void Main()
    {
        var window = new Window(900, 600, "SharpEngine Demo - Basic Window");

        window.AddScene(new Scene());

        window.Run();
    }
}
