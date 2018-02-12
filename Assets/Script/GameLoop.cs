using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour {

    public GameObject spaceX;
    private bool rotate=true;
    float z = 90, a = 5;
    private bool spaceKeyButtton=false;
    private Quaternion transformArrow;
    public float speedFactor;
    private float z1;

    // Use this for initialization
    void Start () {
        print(z);
	}
    private string[] cumle2 = {"Ya Hak", "Tabi buldun beleş roketi salla", "Elon Musk ta öyle diyodu arabasından oldu","Sen bence bırak bu işi"};
    private string[] cumle = { "Hadi bakalım görelim hünerlerini Elon Musk' tan iyi misin?", "Mars'a ilk ayak basan sensin", "Bir koloni değilsin","Yeter artık Mars'ı mı alacan", "Ne kadar da Mars'ı seven bir kişi", "Evet Mars'ta TOKİ başladı" };
    public static int sayac=0;
    private int sayac2=0;
    public Text espiriler;
    public Text espirler2;

    void Update () { 
        if (!Input.GetKeyDown("space") && !spaceKeyButtton)
        {
            if (rotate)
            {
                z += Time.deltaTime * 30;
                z1 = z;
                transform.rotation = Quaternion.Euler(0, 0, z);
                transformArrow = Quaternion.Euler(0, 0, z1-90);
                if (z >= 270)
                    rotate = false;
            }
            else if (!rotate)
            {
                z -= Time.deltaTime * 30;
                z1 = z;
                transform.rotation = Quaternion.Euler(0, 0, z);
                transformArrow = Quaternion.Euler(0, 0, z1-90);
                if (z <= 90)
                    rotate = true;
            }
        }
        else if(Input.GetKeyDown("space"))
        {
            spaceKeyButtton = false;
            GameObject clone = (GameObject)Instantiate(spaceX, transform.position, transformArrow);
            clone.GetComponent<Rigidbody2D>().velocity = transform.right * speedFactor; ;
            print("basıldı");
            a++;
            espirler2.text = cumle2[sayac2];
            if(sayac2!=3)
              sayac2++;
        }
        espiriler.text = cumle[sayac];
    }
}