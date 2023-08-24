using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;
[CustomEditor(typeof(LevelManager))]
public class LevelEditor : Editor
{
    LevelManager levelManager;
    private void Awake()
    {
        levelManager = (LevelManager)target;
    }
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Preview Current Level"))
        {
            levelManager.ApplyLevelData();
        }

    }
}
