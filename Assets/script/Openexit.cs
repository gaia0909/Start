using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openexit : MonoBehaviour
{
    public GameObject panel;

    public void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    public void ExitPanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
}
