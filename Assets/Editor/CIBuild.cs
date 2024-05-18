using UnityEditor;
using UnityEngine;

public static class CIBuild
{
    [MenuItem("Build/WebGL", false, 1)]
    public static void BuildWebGL()
    {
        string[] scenes =
        {
            "Assets/Scenes/App.scene",
        };

        var res = BuildPipeline.BuildPlayer(scenes, "dist/webgl", BuildTarget.WebGL, BuildOptions.None);

        Debug.Log($"BuildPlayer res: {res.summary.result}");
        if (res.summary.result == UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            Debug.Log("构建成功");
        }
        else
        {
            Debug.LogError("构建失败");
        }
    }

    [MenuItem("Build/WeixinMiniGame", false, 1)]
    public static void BuildWeixinMiniGame()
    {
        var res = WeChatWASM.WXConvertCore.DoExport(true);

        Debug.Log($"DoExport res: {res}");
        if (res == WeChatWASM.WXConvertCore.WXExportError.SUCCEED)
        {
            Debug.Log("构建成功");
        }
        else
        {
            Debug.LogError("构建失败");
        }
    }
}
