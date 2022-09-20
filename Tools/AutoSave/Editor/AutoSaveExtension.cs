using System;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace EckTechGames.AutoSave
{
    [InitializeOnLoad]
    public class AutoSaveExtension
    {
        const float waitTimeInSeconds = 60;
        static float timer;
        static AutoSaveExtension()
        {
            //EditorApplication.playModeStateChanged += AutoSaveWhenPlaymodeStarts;
            EditorApplication.update += AutoSaveEveryXSeconds;
        }

        private static void AutoSaveWhenPlaymodeStarts(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredPlayMode)
            {
                var scene = EditorSceneManager.GetActiveScene();
                if (scene.isDirty)
                {
                    EditorSceneManager.SaveScene(scene, null, false);
                }
                AssetDatabase.SaveAssets();
                //Debug.Log("Autosave " + DateTime.Now.ToString("HH:mm:ss tt"));
            }
        }
        private static void Save()
        {
            if (Application.isPlaying == false)
            {
                var scene = EditorSceneManager.GetActiveScene();
                if (scene.isDirty)
                {
                    EditorSceneManager.SaveScene(scene, null, false);
                }
                AssetDatabase.SaveAssets();
               
            }
         
        }
        private static void AutoSaveEveryXSeconds()
        {
            if ((Time.realtimeSinceStartup - timer) > waitTimeInSeconds)
            {
                //AutoSaveWhenPlaymodeStarts(PlayModeStateChange.EnteredPlayMode);
                Save();
                timer = Time.realtimeSinceStartup;
              
            }
        }
    }

}