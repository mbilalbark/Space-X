using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spacex : MonoBehaviour {

    //private string[] cumle = { "Elon Musk'tan iyisin", "Bir koloni değilsin", "Mars'a ayak basan ilk sensin", "Yeter artık Mars'ı mı alacan", "Ne kadar da Mars'ı seven bir kişi", "Evet Mars'ta TOKİ başladı" }; 
	
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "mars")
        {
            Destroy(gameObject);
            print("oldu");
            if (GameLoop.sayac != 5)
                GameLoop.sayac++;
        }
        else
            Destroy(gameObject);
    } 
}
