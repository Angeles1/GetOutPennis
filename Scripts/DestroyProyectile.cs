using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProyectile : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectil")
        {
            Destroy(collision.gameObject);
        }
    }


}
