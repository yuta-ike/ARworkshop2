//このコードはコピペしてもらう

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AppManager : MonoBehaviour
{
    //現在のシーン情報
    public static IReadOnlyReactiveProperty<(SceneTypes type, int count, int totalCount)> CurrScene => currScene;
    private static ReactiveProperty<(SceneTypes type, int count, int totalCount)> currScene = new ReactiveProperty<(SceneTypes type, int count, int totalCount)>((type: SceneTypes.ModelViewer, count:0, totalCount:0));

    //データストア
    private Dictionary<SceneTypes, int> datastore = new Dictionary<SceneTypes, int>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, 100f))
            {
                //衝突したオブジェクトのUIPanelコンポーネントを取得
                UIPanel uipanel = hit.collider.gameObject.GetComponent<UIPanel>();
                if (uipanel != null)
                {
                    //totalCountを1増やす
                    datastore[uipanel.Type] += 1;
                    if (uipanel.Type == currScene.Value.type)
                    {
                        //カウントを1増やす
                        currScene.Value = (type: uipanel.Type, count: currScene.Value.count + 1, totalCount: datastore[uipanel.Type]);
                    }
                    else
                    {
                        currScene.Value = (type: uipanel.Type, count: 0, totalCount: datastore[uipanel.Type]);
                    }
                }
            }
        }
    }
}
