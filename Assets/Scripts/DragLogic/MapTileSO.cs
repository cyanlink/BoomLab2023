using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTileSO : ScriptableObject
{
    [SerializeField]
    private bool top, bottom, left, right;

    [SerializeField]
    private Sprite mapSprite;

    public bool DirectionState(MapDirections dir)
    {
        return dir switch
        {
            MapDirections.top => top,
            MapDirections.bottom => bottom,
            MapDirections.left => left,
            MapDirections.right => right,
            _ => throw new System.NotImplementedException(),
        };
    }
}

public enum MapDirections
{
    top, bottom, left, right
}