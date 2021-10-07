using UnityEngine;
using UnityEditor;


#if UNITY_EDITOR

public class VersionMenuButton : EditorWindow
{

    [MenuItem("U/Universal Web/Version")]
    public static void PrintVersion()
    {

        Debug.Log(" U Framework: Universal Web v1.0.0 for Unity");

    }
}


#endif
