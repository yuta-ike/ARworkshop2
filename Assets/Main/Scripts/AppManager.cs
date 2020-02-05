using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class AppManager : MonoBehaviour
{
    private ReactiveProperty<SceneTypes> currScene = new ReactiveProperty<SceneTypes>(SceneTypes.ModelViewer);
    public IReadOnlyReactiveProperty<SceneTypes> CurrScene => currScene;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, 100f))
            {
                UIPanel uipanel = hit.collider.gameObject.GetComponent<UIPanel>();
                currScene.Value = uipanel.Type;
            }
        }
    }
}
