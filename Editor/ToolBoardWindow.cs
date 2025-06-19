using UnityEditor;
using UnityEngine;

public class ToolBoardWindow : EditorWindow
{
    [MenuItem("Tools/Tool Board")]
    public static void ShowWindow()
    {
        GetWindow<ToolBoardWindow>("Tool Board");
    }

    private void OnGUI()
    {
        GUILayout.Label("Basic Tools:");
        GUILayout.Space(45);


        GUILayout.Label("World");
        if (GUILayout.Button(highDetail ? "Restore LOD" : "Force LOD to High Detail"))
        {
            QualitySettings.lodBias = highDetail ? 1f : 1000f;
            highDetail = !highDetail;
        }
    }
}
