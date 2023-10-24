using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeler : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            _GameManager.ObjeSayar();
          
        }
    }
}
