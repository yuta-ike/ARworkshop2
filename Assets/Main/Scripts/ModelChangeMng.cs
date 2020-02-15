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
    private int init_model;

    private int now_model;


    // Start is called before the first frame update
    void Start()
    {
        now_model = init_model;
        foreach (ModelBhv model in models)
        {
            model.Hide();
        }

        AppManager.CurrScene.Subscribe(currScene => {
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
        });
    }

    public void ChangeModel(int next)
    {
        models[now_model].Hide();
        models[next].Show();
        now_model = next;
    }
}
