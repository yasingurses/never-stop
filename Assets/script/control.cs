using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class control : MonoBehaviour
{
    public float karakterhizi;
    public Rigidbody2D rb;
    private float kullanicigirisi;
    public TextMeshProUGUI text;
    int skor;
     
    void Update()
    {
        text.text = "Skor : " + skor;
        kullanicigirisi = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(kullanicigirisi * karakterhizi, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Bitis")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
        if(temas.gameObject.tag=="Platform")
        {
            skor += Random.Range(2,30);
        }
    }
}
