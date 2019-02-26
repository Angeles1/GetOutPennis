using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour {

    /*Datos del enemigo */
    public Animator m_Animator;
    public GameObject enemigo;
    public int vida;
    public int vidaMax;
    public GameObject HPBar;
    public GameObject HBBordes;
    public int cantidadMonedas = 2;
    public float velocidad = 1;
    public Inmunities inmunities;

    public int fuerza;

    public AudioSource audioEffect;
    public AudioClip audioGolpeDiu;
    public AudioClip audioGolpeCondon;
    public AudioClip audioGolpeCopa;


    [SerializeField]
    private int monedas;


    [System.Serializable]
    public struct Inmunities
    {
        public bool tirachinas;
        public bool diu;
        public bool charco;
    }

    public void Start()
    {
        vidaMax = vida;
       audioEffect = GameObject.Find("AudioEffects").GetComponent<AudioSource>();

}

public void Update()
    {
        if (HBBordes != null)
        {
            ShowHP();
        }
    }

    public int GetVida()
    {
        return vida;
    }

    public void ShowHP()
    {
        float z = (float)vida / (float)vidaMax;
        Vector3 scaleBar = new Vector3(z, -0.7960093f, 0);
        HPBar.transform.localScale = scaleBar;
    }

    public int Monedas
    {
        get
        {
            return monedas;
        }
    }

    public int GetFuerza()
    {
        return fuerza;
    }

    public void PerderVida(int daño, string nombreProyectil)
    {
        if(nombreProyectil == "Proyectil Prefab(Clone)")
        {
            audioEffect.GetComponent<AudioSource>().clip = audioGolpeCondon ;
            m_Animator.SetTrigger("Golpeado");
        }

        if (nombreProyectil == "Diu Prefab(clone)")
        {
            audioEffect.GetComponent<AudioSource>().clip = audioGolpeDiu;

            m_Animator.SetTrigger("Electrocutado");
        }

        if (nombreProyectil == "Flujo Prefab(clone)")
        {
            audioEffect.GetComponent<AudioSource>().clip = audioGolpeCopa;

            m_Animator.SetTrigger("Ahogado");
        }

        audioEffect.Play();
        Golpear(daño);
    }

    public void Golpear(int daño)
    {
        vida = vida - daño;
        if (vida <= 0)
        {
            Destroy(gameObject.GetComponent<EnemyAI>());
            Destroy(HBBordes);
            Coins.coins += cantidadMonedas;
            m_Animator.SetBool("Morir", true);
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}
