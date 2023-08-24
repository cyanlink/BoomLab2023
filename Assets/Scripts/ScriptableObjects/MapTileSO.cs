using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MapTileSO : ScriptableObject
{
    [SerializeField]
    private bool top, bottom, left, right;

    public Sprite mapSprite;

    private bool isStart, isDestination;

    private void OnValidate()
    {
        //mutual exclusive
        if(isStart){
            isDestination = false;
        }
        if (isDestination)
        {
            isStart = false;
        }
    }

    public bool GetDirectionAllow(MapDirections dir)
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

static class MapDirectionsHelper
{
    public static MapDirections GetOppositeDirection(MapDirections dir)
    {
        return dir switch
        {
            MapDirections.top => MapDirections.bottom,
            MapDirections.bottom => MapDirections.top,
            MapDirections.left => MapDirections.right,
            MapDirections.right => MapDirections.left,
            _ => throw new System.NotImplementedException(),
        };
    }
}