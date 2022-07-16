using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float ziplamagucu;
    private Vector2 karakterhizi;
    private Rigidbody2D fizik;

    private void OnCollisionEnter2D(Collision2D temas)
    {

        if (temas.relativeVelocity.y <= 0) {  

        fizik = temas.collider.GetComponent<Rigidbody2D>();

        if(fizik != null)
        {
            karakterhizi = fizik.velocity;
            karakterhizi.y = ziplamagucu;
                fizik.velocity = karakterhizi;
        }
    }
    }
}
