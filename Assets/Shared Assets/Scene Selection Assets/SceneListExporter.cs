#if UNITY_EDITOR

using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace SharedAssets
{
    /// <summary>
    /// A utility to get all the scenes available in ths scene
    /// </summary>
    /// <remarks>
    /// Taken from https://gist.github.com/thebeardphantom/28ec29accea44af7dbd6a5354b36cdef
    /// For future reference, develop this https://docs.unity3d.com/ScriptReference/EditorBuildSettings-scenes.html
    /// </remarks>
    public static class SceneListExporter
    {
        //[DidReloadScripts]
        [MenuItem("Assets/Generate Scene List")]
        private static void GenerateSceneList()
        {
            if (Application.isPlaying)
            {
                return;
            }

            var sceneNames = (from s in EditorBuildSettings.scenes
                where s.enabled
                select Path.GetFileNameWithoutExtension(s.path)).ToArray();
            var path = Path.Combine(Application.dataPath, "Resources");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, "scenes.txt");
            File.WriteAllLines(path, sceneNames);
            AssetDatabase.Refresh();
            /* Access scenes at runtime:
             * 
             * var sceneList = Resources.Load<TextAsset>("scenes");
             * var scenes = sceneList.text.Split('\n');
             */
        }
    }
}
#endif