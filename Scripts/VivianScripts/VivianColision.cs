using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VivianColision : MonoBehaviour {

    public static int vidaVivian = 10;

    public static int control;
    //vidaControlVivian controlSprites = new vidaControlVivian();
    Animator animator;

    [SerializeField]
    private Sprite muerteSprite;



    private void Start()
    {
       vidaVivian = 10;
       control = vidaVivian;
    }

    public int GetVida()
    {
        return vidaVivian;
    }

    /* Enemigo chocando con vivian */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject enemigo = collision.gameObject;
        EnemyType Dolor = (EnemyType)enemigo.GetComponent(typeof(EnemyType));
        int fuerza = Dolor.GetFuerza();
        vidaVivian = vidaVivian - fuerza;

        animator = GetComponent<Animator>();
        animator.SetTrigger("Golpe");
        this.GetComponent<AudioSource>().Play();
        if (vidaVivian <= 0)
        {
            muerteVivian();
        }
    }

    private void muerteVivian()
    {
        vidaVivian = 0;
        gameObject.GetComponent<SpriteRenderer>().sprite= muerteSprite;
        animator.SetBool("IsMuerte", true);
        Time.timeScale = 1f;

        SceneManager.LoadSceneAsync("Fin");
    }

}
