using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ModelChangeMng : MonoBehaviour
{
    [SerializeField]
    private SceneTypes sceneType;

    //modelsには、同時に出現させたいやつをまとめて空オブジェクトの子とかにしてその空オブジェクトをいれる
    [SerializeField]
    //Type制限
    private ModelBhv[] models;

    [SerializeField]
    private int initModelID;

    private int currModelID;


    // Start is called before the first frame update
    void Start()
    {
        /*ここを記述*/
        currModelID = initModelID;
        foreach (ModelBhv model in models)
        {
            model.Hide();
        }
        /*ここまで*/

        AppManager.CurrScene.Subscribe(currScene => {
            /*ここを記述*/
            if (currScene.type == sceneType)
            {
                gameObject.SetActive(true);

                //ゼロ除算
                int next = currScene.count % models.Length;
                ChangeModel(next);
            }
            else
            {
                gameObject.SetActive(false);
            }
            /*ここまで*/
        });
    }

    public void ChangeModel(int next)
    {
        models[currModelID].Hide();
        models[next].Show();
        currModelID = next;
    }
}
