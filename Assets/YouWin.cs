using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
   public GameObject youwinPanel;


   private void OnTriggerEnter(Collider other)
   {
    if (other.tag == "Player")
    {
        youwinPanel.SetActive(true);
        Time.timeScale = 0f;
    }

   }
}
