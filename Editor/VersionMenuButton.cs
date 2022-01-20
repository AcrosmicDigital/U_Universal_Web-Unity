using UnityEngine;
using UnityEditor;

namespace U.Universal.Web.Editor
{
    public class VersionMenuButton : EditorWindow
    {

        [MenuItem("Universal/Web/Version")]
        public static void PrintVersion()
        {

            Debug.Log(" U Framework: Universal Web v1.0.0 for Unity");

        }
    }
}