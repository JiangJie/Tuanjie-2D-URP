using UnityEditor;

public static class CIBuild
{
    [MenuItem("Build/WebGL", false, 1)]
    public static void BuildWebGL()
    {
        string[] scenes =
        {
            "Assets/Scenes/App.scene",
        };

        BuildPipeline.BuildPlayer(scenes, "dist/webgl", BuildTarget.WebGL, BuildOptions.None);
    }

    [MenuItem("Build/WeixinMiniGame", false, 1)]
    public static void BuildWeixinMiniGame()
    {
        WeChatWASM.WXConvertCore.DoExport(true);
    }
}
