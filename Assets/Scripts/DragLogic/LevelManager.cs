using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private TMP_Text mainDialogText;

    [SerializeField] private LevelSO levelData;

    [SerializeField] private JigsawGrid jigsawGrid;

    public void ApplyLevelData()
    {
        jigsawGrid.ApplyLevelData(levelData);
    }

    internal void DoStep()
    {
        throw new NotImplementedException();
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
