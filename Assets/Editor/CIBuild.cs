using UnityEditor;
using UnityEngine;

public static class CIBuild
{
    public static void BuildWeixinMiniGame()
    {
        // string[] scenes =
        // {
        //     "Assets/Scenes/SampleScene.unity",
        // };

        // var buildPath = "dist";

        // BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.WeixinMiniGame, BuildOptions.None);
        // Debug.Log("Build completed successfully.");

        WeChatWASM.WXConvertCore.DoExport(true);
    }
}
