using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class VideoHandler : MonoBehaviour
{
    [SerializeField]
    private SceneTypes sceneType;

    void Start()
    {
        VideoController vController = GetComponent<VideoController>();
        bool onPlay = false;

        AppManager.CurrScene.Subscribe(currScene => {
            /*ここを記述*/
            if (currScene.type == sceneType)
            {
                gameObject.SetActive(true);

                if (onPlay)
                {
                    vController.Pause();
                }
                else
                {
                    vController.Play();
                }
                onPlay = !onPlay;
            }
            else
            {
                gameObject.SetActive(false);
                vController.Pause();
                onPlay = false;
            }
            /*ここまで*/
        });
    }
}
