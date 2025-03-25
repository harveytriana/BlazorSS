using System.Reflection;

using SkiaSharp;

namespace BlazorSS.Services;

/// <summary>
/// The font files has to be Embedded resource
/// </summary>
public class TypeFaceService
{
    readonly Dictionary<string, SKTypeface> _typeFaces = [];

    public SKTypeface GetTTF(string ttfName)
    {
        if(_typeFaces.TryGetValue(ttfName, out SKTypeface? value)) {
            return value;
        }
        if(LoadTypeFace(ttfName)) {
            return _typeFaces[ttfName];
        }
        return SKTypeface.Default;
    }

    bool LoadTypeFace(string ttfName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        try {
            var fileName = ttfName + ".ttf";
            foreach(var resourcePath in assembly.GetManifestResourceNames()) {
                if(ExitsResourceName(resourcePath, fileName)) {
                    Console.WriteLine("Load Typeface {0}", ttfName);
                    var s = assembly.GetManifestResourceStream(resourcePath);
                    var f = SKTypeface.FromStream(s);
                    _typeFaces.Add(ttfName, f);
                    return true;
                }
            }
        }
        catch {/* missing resource */}
        return false;
    }

    public static bool ExitsResourceName(string resourcePath, string name)
    {
        return resourcePath.EndsWith(name, StringComparison.OrdinalIgnoreCase);
    }
}
