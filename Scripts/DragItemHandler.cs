using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CircleCollider2D))]
public class DragItemHandler : MonoBehaviour{
/*
    private Vector3 screenPoint;
    private Vector3 offset;
    private GameObject newTower;

    void OnMouseDown()
    {
        newTower = Instantiate(gameObject);
        offset = newTower.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
        
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        newTower.transform.position = curPosition;
    }
    */
}
