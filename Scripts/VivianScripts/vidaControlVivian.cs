using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaControlVivian : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;

    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;

    Sprite aux; 

    // Use this for initialization
    public void Start()
    {
       
        spriteRenderer = GameObject.Find("vidaVivian").GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) // 
            spriteRenderer.sprite = sprite0; // set the sprite to sprite1
            
    }

    public void Update()
    {
        if (aux == null) {
            aux = sprite0;
        }
        GameObject.Find("vidaVivian").GetComponent<SpriteRenderer>().sprite = aux;
        ChangeSprite();
    }

    /*Estamos en ello */
    public void ChangeSprite()
    {
        int vida = VivianColision.vidaVivian;
        int vidacontrol = VivianColision.control;

        aux = sprite3;
        vidacontrol = vidacontrol / 11;
        if (vida ==10 )
        {
           aux= sprite0;
        }
        else if (vida ==9)
        {
            aux = sprite1;
        }
        else if (vida ==8)
        {
            aux = sprite2;
        }
        else if (vida ==7)
        {
            aux = sprite3;
        }
        else if (vida ==6)
        {
            aux = sprite4;
        }
        else if (vida ==5)
        {
            aux = sprite5;
        }
        else if (vida ==4)
        {
            aux = sprite6;
        }
        else if (vida ==3)
        {
            aux = sprite7;
        }
        else if (vida ==2)
        {
            aux = sprite8;
        }
        else if (vida ==1)
        {
            aux = sprite9;
        }
        else if (vida ==0)
        {
            aux = sprite10;
        }
        spriteRenderer.sprite = aux;

    }
}
