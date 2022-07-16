using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgen : MonoBehaviour
{
    public GameObject zemin;
    public int zeminsayisi;
    public float minx, maxX;
    public float miny, maxy;

    void Start()
    {
        Vector3 level = new Vector3();
       
        for (int i=0;i<zeminsayisi;i++) {
            level.x = Random.Range(minx, maxX);
            level.y = Random.Range(miny, maxy);

            Instantiate(zemin, level, Quaternion.identity);

        }
    }

     
}
