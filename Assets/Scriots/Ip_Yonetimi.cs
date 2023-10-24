using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ip_Yonetimi : MonoBehaviour
{
    public Rigidbody2D IlkKanca;
    public Top _Top;
    public int BaglantiSayisi = 5;
    public string HingeAdi;
    public GameObject[] BaglantiHavuzu;
    void Start()
    {
        Ip_Olustur();
    }

    void Ip_Olustur()
    {
        Rigidbody2D OncekiBaglanti = IlkKanca;
        for (int i = 0; i < BaglantiSayisi; i++)
        {
            BaglantiHavuzu[i].SetActive(true);         
            HingeJoint2D joint= BaglantiHavuzu[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = OncekiBaglanti;
            if (i<BaglantiSayisi-1)
            {
                OncekiBaglanti = BaglantiHavuzu[i].GetComponent<Rigidbody2D>();
            }
            else
            {
                _Top.SonZinciriBagla(BaglantiHavuzu[i].GetComponent<Rigidbody2D>(), HingeAdi);
            }
        }
    }
}
