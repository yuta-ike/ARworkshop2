using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelBhv : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), 1f);
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