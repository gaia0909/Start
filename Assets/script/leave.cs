using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class leave : MonoBehaviour
{
   
    void Start()
    {
        
    }

   public void quitgame()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }
}
