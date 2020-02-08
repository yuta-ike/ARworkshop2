using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private SceneTypes sceneType;

    void Start()
    {
        AppManager.CurrScene.Subscribe(currScene => { 
            if(currScene == sceneType)
            {
                GetComponent<Renderer>().enabled = true;
            }
            else
            {
                GetComponent<Renderer>().enabled = false;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
