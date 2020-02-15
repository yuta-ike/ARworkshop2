using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class DocumentHandler : MonoBehaviour
{
    [SerializeField]
    private SceneTypes sceneType;

    void Start()
    {
        AppManager.CurrScene.Subscribe(currScene => {
            /*ここを記述*/
            if(currScene.type == sceneType)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
            /*ここまで*/
        });
    }
}
