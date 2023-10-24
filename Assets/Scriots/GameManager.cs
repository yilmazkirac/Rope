using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Top[] _Top;
    [SerializeField] private GameObject[] Paneller;
    public int KacObjeOlacak;
    public int YokEdilenObje;
    bool Acikmi;
    private void Start()
    {
        Invoke("Kaybettin",18);
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider!=null)
            {
                if (hit.collider.CompareTag("Merkez_1"))
                {
                    
                    hit.collider.gameObject.SetActive(false);
                    _Top[0].HingeKontrol["Merkez_1"].enabled = false;
                }
               else if (hit.collider.CompareTag("Merkez_2"))
                {
                    hit.collider.gameObject.SetActive(false);
                    _Top[0].HingeKontrol["Merkez_2"].enabled = false;
                }
                else if (hit.collider.CompareTag("Merkez_3"))
                {
                    hit.collider.gameObject.SetActive(false);
                    _Top[1].HingeKontrol["Merkez_3"].enabled = false;
                }
                else if (hit.collider.CompareTag("Merkez_4"))
                {
                    hit.collider.gameObject.SetActive(false);
                    _Top[1].HingeKontrol["Merkez_4"].enabled = false;
                }
            }
          
        }
      
    }
    public void NextLevel()
    {
        Time.timeScale = 1;
        Paneller[2].SetActive(true);
        PlayerPrefs.SetInt("Level",PlayerPrefs.GetInt("Level")+1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    
    }
    public void TryAgain()
    {
        Time.timeScale = 1;
        Paneller[2].SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   

    }
    public void ObjeSayar()
    {
        YokEdilenObje++;
        if (KacObjeOlacak == YokEdilenObje)
        {
            Kazandin();
        }
    }

    public void Kazandin()
    {
        Paneller[0].SetActive(true);
        Paneller[2].SetActive(false);
        CancelInvoke();
        Time.timeScale = 0;
    }
    public void Kaybettin()
    {
        Paneller[1].SetActive(true);
        Paneller[2].SetActive(false);
        Time.timeScale = 0;    
    }
    public void Durdur()
    {
        if (!Acikmi)
        {
            Paneller[3].SetActive(true);
            Acikmi=true;
        }
        else
        {
            Paneller[3].SetActive(false);
            Acikmi = false;
        }
       
    }
}