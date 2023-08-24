using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSO : ScriptableObject
{
    [SerializeField]
    public LevelMap levelMap;

    public bool CanMove(MapTileSO tile, MapDirections dir)
    {
        bool localAllow = tile.GetDirectionAllow(dir);
        if (!localAllow) return false;//����tile������򶼲�ͨ
        var coord = levelMap.GetPosition(tile);
        switch (dir)
        {
            case MapDirections.top:
                coord.Set(coord.x, coord.y+1); break;
            case MapDirections.bottom:
                coord.Set(coord.x, coord.y -1); break;
            case MapDirections.left:
                coord.Set(coord.x-1, coord.y); break;
            case MapDirections.right:
                coord.Set(coord.x+1, coord.y); break;
        }
        if (coord.x < 0 || coord.y < 0 || coord.x >= levelMap.rowSize || coord.y >= levelMap.columnSize)
            return false;//�����˵�ͼ�߽�
        var destTile = levelMap[coord.x][coord.y];
        var destDir = MapDirectionsHelper.GetOppositeDirection(dir);
        bool destAllow = destTile.GetDirectionAllow(destDir);
        return destAllow;//����Ǹ�ͼ��Ҳ������������
    }
}

[Serializable]
public struct LevelMap
{
    public int columnSize, rowSize;
    public List<MapTileSO> map;

    public List<MapTileSO> this[int column] => GetRow(column);

    /// <summary>
    /// �������ǲ�����Ҫ�����������
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="tile"></param>
    public void SetTile(int x, int y, MapTileSO tile)
    {
        this[y][x] = tile;
    }
    /// �������ǲ�����Ҫ�����������
    public MapTileSO GetTile(int x, int y)
    {
        return this[y][x];
    }

    public List<MapTileSO> GetRow(int column)
    {
        int startIndex = column * rowSize;
        return map.GetRange(startIndex, startIndex + rowSize);
    }

    public Vector2Int GetPosition(MapTileSO tile)
    {
        int index = map.IndexOf(tile);
        int column = index / rowSize;//floor
        int row = index % rowSize;
        return new Vector2Int(column, row);
    }
}