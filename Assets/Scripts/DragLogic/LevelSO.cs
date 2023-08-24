using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSO : ScriptableObject
{
    [SerializeField]
    LevelMap levelMap;

    public bool CanMove(MapTileSO tile, MapDirections dir)
    {
        
    }
}

[Serializable]
public struct LevelMap
{
    List<List<MapTileSO>> map;
    public List<MapTileSO> this[int key]
    {
        get => map[key];
        set { map[key] = value; }
    }
}