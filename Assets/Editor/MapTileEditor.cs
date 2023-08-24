using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;
[CustomEditor(typeof(MapTileSO))]
public class MapTileEditor : Editor
{
    MapTileSO mapTile;


    private void Awake()
    {
        mapTile = target as MapTileSO;        
    }
    public override void  OnInspectorGUI()
    {
        base.OnInspectorGUI();
        var texture = AssetPreview.GetAssetPreview(mapTile.mapSprite);
        GUILayout.Label(texture);
    }
}
