using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
  
    public void Change()
    {
        SceneManager.LoadScene("game");
    }
}
