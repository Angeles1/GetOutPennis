using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverScript : Singleton<HoverScript> {
    
    private SpriteRenderer spriteRenderer;
    private SpriteRenderer RangespriteRenderer;

    // Use this for initialization
    void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        RangespriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update () {
        FollowMouse();
	}

    private void FollowMouse()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    public void Activate(Sprite sprite)
    {
        this.spriteRenderer.sprite = sprite;
        spriteRenderer.enabled = true;
        RangespriteRenderer.enabled = true;

    }

    public void Deactivate()
    {
        spriteRenderer.enabled = false;
        RangespriteRenderer.enabled = false;

    }

}
