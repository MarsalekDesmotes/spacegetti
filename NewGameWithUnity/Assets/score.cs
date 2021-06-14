using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    Text s;
    void Start()
    {
        s = GetComponent<Text>();
        astro_hareket.coins = 6;
    }

    // Update is called once per frame
    void Update()
    {
        s.text = "Score:" + (astro_hareket.coins-6);
        if ((astro_hareket.coins) % 5 == 0)
        {
            Debug.Log("oyun hizlaniyor!");
            camera_follow.hiz += 0.1f;

        }
    }
}
