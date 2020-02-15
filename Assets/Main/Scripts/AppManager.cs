using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AppManager : MonoBehaviour
{
    private static ReactiveProperty<(SceneTypes type, int count)> currScene = new ReactiveProperty<(SceneTypes type, int count)>((type: SceneTypes.ModelViewer, count:0));
    public static IReadOnlyReactiveProperty<(SceneTypes type, int count)> CurrScene => currScene;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, 100f))
            {
                UIPanel uipanel = hit.collider.gameObject.GetComponent<UIPanel>();
                if (uipanel != null)
                {
                    if (uipanel.Type == currScene.Value.type)
                    {
                        currScene.Value = (type: uipanel.Type, count: currScene.Value.count + 1);
                    }
                    else
                    {
                        currScene.Value = (type: uipanel.Type, count: 0);
                    }
                }
            }
        }
    }
}
