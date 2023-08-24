using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableMapTileItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDropHandler, IDragHandler
{
    private LevelManager levelManager;
    private MapTileSO tileData;
   

    private DraggableMapTileItem follow;
    private Image image;

    public void InitializeContent(MapTileSO tile)
    {
        this.tileData = tile;
        image.sprite = tile.mapSprite;

    }

    private void Awake()
    {
        image = GetComponentInChildren<Image>();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }

    public event Action<DraggableMapTileItem> OnTileDroppedOn, OnTileBeginDrag, OnTileEndDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }


}
