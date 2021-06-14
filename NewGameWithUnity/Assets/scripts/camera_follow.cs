using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera_follow : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 camera_payi;
    public float kuvvet_katsayisi = 0.1f;
    public float Speed_karsila = astro_hareket.speed;
    public float speed2;
    public static float hiz = 400f; //kamera hýzý burasý 500f ideal
    public static Transform transform_camera;

    public float zaman;

    public static int sayac;












    Rigidbody2D camera_rigit; //rigitbody'e bu nesne ile ulaþýcaz


    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("hero"))
        {
         SceneManager.LoadScene("GameOver");

        }
            

    }









    private void Start()
    {
        camera_rigit = GetComponent<Rigidbody2D>(); //yukarýda tanýmladýðýmýz nesnenin ve 'rb' referans deðerinin nereyi referans alacaðýný burada belirttik 
        
        

    }


    // Update is called once per frame

    private void FixedUpdate()
    {
        if (hap_ters.hap_yutma == 1) //yani true' ise 
        {
            transform.rotation = Quaternion.Euler(0, 0, 180); //opsiyon 1
           /* transform.localScale = new Vector3(1, -1, 1); */
        }
        zaman += Time.deltaTime;
        if (zaman <= 7 && zaman >= 6 && sayac != 1)
        {
            sayac++;
            astro_hareket.speed *= 1.150f; //buradan kamera hýzý il birlikte astronot hýzýnýda artýrmýþ olduk 
            hiz *= 1.150f;
            camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
            Debug.Log("Hizlan !!!");
        }
        camera_rigit.velocity = transform.right * hiz * Time.deltaTime;
    }
    void LateUpdate()//Update fonksiyonu çalýþtýktan hemen sonra çalýþýyor 
    {



        /*camera_rigit.AddForce(transform.right * kuvvet_katsayisi);
        transform.position = targetObject.transform.position + camera_payi; //camera ile cisim arasýna pay býraktýk */
    }
}










 









