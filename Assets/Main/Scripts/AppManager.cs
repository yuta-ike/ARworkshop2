using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AppManager : MonoBehaviour
{
    private ReactiveProperty<SceneTypes> currScene = new ReactiveProperty<SceneTypes>(SceneTypes.ModelViewer);
    public IReadOnlyReactiveProperty<SceneTypes> CurrScene => currScene;

    void Start()
    {

    }

    void ShowVideo()
    {
        currScene.Value = SceneTypes.Video;
    }

    void ShowDocument()
    {
        currScene.Value = SceneTypes.Document;
    }

    void ShowModelViewer()
    {
        currScene.Value = SceneTypes.ModelViewer;
    }
}
