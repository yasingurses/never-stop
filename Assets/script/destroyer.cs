using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D temas)
    {
        float xdeger = Random.Range(-6f,6f);
        float ydeger =9f;
        if(temas.tag == "Platform")
        {
            temas.transform.position = new Vector3(xdeger, transform.position.y + ydeger, transform.position.z);
        }
    }
}
