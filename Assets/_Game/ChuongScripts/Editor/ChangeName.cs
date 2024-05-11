using System.IO;
using UnityEditor;
using UnityEngine;

namespace _Game.ChuongScripts.Editor
{
    public class ChangeName : MonoBehaviour
    {
        [MenuItem("Assets/Tools/ChangeUnitName")]
        public static void ChangeUnitName()
        {
            // Get the selected sprite file
            var objects = Selection.objects;
            int i = 0;
            foreach (var selectedObject in objects)
            {
                string assetPath = AssetDatabase.GetAssetPath(selectedObject);
            
                if (!string.IsNullOrEmpty(assetPath) && assetPath.EndsWith(".png"))
                {
                    var directoryName = Path.GetDirectoryName(assetPath);
                    if (directoryName is null) return;
                    string newPath = Path.Combine(directoryName, $"{i.ToString()}.png");
                    i++;
                    Debug.Log(newPath);
                    AssetDatabase.RenameAsset(assetPath, $"{i.ToString()}.png");
                    // Refresh the Asset Database to see the changes
                    AssetDatabase.Refresh();
                }
            }
        }
    }
}