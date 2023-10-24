using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenu : MonoBehaviour
{

    private void Update()
    {
        if (!PlayerPrefs.HasKey("IlkAcilis"))
        {
            PlayerPrefs.SetInt("IlkAcilis", 1);
            PlayerPrefs.SetInt("Level", 1);
        }
        if (PlayerPrefs.HasKey("IlkAcilis"))
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
    }

}
