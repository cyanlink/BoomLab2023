using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grap : MonoBehaviour
{
    [SerializeField] private GameObject grap;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (grap == null)
            {
                RaycastHit hit = CastRay();
                if (hit.collider != null)
                {
                    if (!hit.collider.CompareTag("puzzle"))
                    {
                        return;
                    }
                    
                    grap = hit.collider.gameObject;
                    Cursor.visible = false;
                }
            }
            else
            {
                Vector3 position = new Vector3(Input.mousePosition.x , Input.mousePosition.y, Camera.main.WorldToScreenPoint(grap.transform.position).z);
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
                grap.transform.position = new Vector3(worldPosition.x, 0, worldPosition.z);
                
                grap= null;
                Cursor.visible = true;
            }
        }

        if (grap !=null)
        {
            Vector3 position = new Vector3(Input.mousePosition.x , Input.mousePosition.y, Camera.main.WorldToScreenPoint(grap.transform.position).z);
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(position);
            grap.transform.position = new Vector3(worldPosition.x,.25f,worldPosition.z);
            if (Input.GetMouseButtonDown(1))
            {
                grap.transform.rotation = Quaternion.Euler(new Vector3(
                    grap.transform.rotation.eulerAngles.x,
                    grap.transform.rotation.eulerAngles.y + 90,
                    grap.transform.rotation.eulerAngles.z));
            }
        }
    }

    private RaycastHit CastRay()
    {
        Vector3 screenMousePosFar = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.farClipPlane);
        Vector3 screenMousePosNear = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            Camera.main.nearClipPlane);
        Vector3 worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
        Vector3 worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
        RaycastHit hit;
        Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);

        return hit;
    }
}
