using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMenuCameraMove : MonoBehaviour
{
    public Transform _menuCanvas;
    public Transform _stageCanvas;
    
    public float _smoothValue = 0f;
    public Vector3 _pos; // 변경되기로 원하는 위치

    void Start()
    {
        // MoveDown();
        // StartCoroutine("FadeIn");
    }

    void LateUpdate()
    {
        // MoveDown();
    }

    public void MoveDown()
    {
        // _menuCanvas.gameObject.SetActive(false);

        // 회전
        transform.rotation = Quaternion.RotateTowards(transform.rotation, _stageCanvas.rotation, 3f);

        transform.position = Vector3.Lerp(transform.position, _pos, Time.fixedDeltaTime + 5f);

    }

    IEnumerator FadeIn()
    {
        for(float i = 1f; i >= 0; i -= 0.1f)
        {
            Color color = new Vector4(1,1,1, i);
            // transform.renderer.material.color = color;
            yield return 0;
        }
    }

}
