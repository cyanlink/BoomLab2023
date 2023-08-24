using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JigsawGrid : MonoBehaviour
{
    [SerializeField] private List<DraggableMapTileItem> placeholder;

    private LevelSO levelData;
    internal void ApplyLevelData(LevelSO levelData)
    {
        this.levelData = levelData;
        for(int i = 0; i < placeholder.Count; i++)
        {
            var tile = levelData.levelMap.map[i];
            placeholder[i].InitializeContent(tile);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
