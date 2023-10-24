using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{

    public float zincirMesafesi=0.2f;
    public Dictionary<string, HingeJoint2D> HingeKontrol = new Dictionary<string, HingeJoint2D>();
    public void SonZinciriBagla(Rigidbody2D rb,string HingeAdi)
    {
        HingeJoint2D joint =gameObject.AddComponent<HingeJoint2D>();
        HingeKontrol.Add(HingeAdi, joint);
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody= rb;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -zincirMesafesi);
    }

}
