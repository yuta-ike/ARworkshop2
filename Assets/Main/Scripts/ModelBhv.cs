using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelBhv : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
    }


    public bool Show()
    {
        if (gameObject.activeSelf)
        {
            return false;
        }
        else
        {
            gameObject.SetActive(true);
            return true;
        }
    }

    public bool Hide()
    {
        if (!gameObject.activeSelf)
        {
            return false;
        }
        else
        {
            gameObject.SetActive(false);
            return true;
        }
    }
}