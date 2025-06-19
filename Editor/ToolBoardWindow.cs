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
        GUILayout.Label("Editor Tools", EditorStyles.boldLabel);
    }
}
