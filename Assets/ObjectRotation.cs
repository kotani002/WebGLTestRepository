using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    [SerializeField]
    private GameObject _rotateObject = null;
    [SerializeField]
    private TMP_Text _text = null;
    // Start is called before the first frame update
    void Start()
    {
        _text.text = ("0:0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touches.Length > 0)
        {
            Vector2 inch = new Vector2(
            Input.touches[0].deltaPosition.x / Screen.dpi,
            Input.touches[0].deltaPosition.y / Screen.dpi
            );
            Debug.Log("inch dpi : " + Screen.dpi + ", x : " + inch.x + ", y : " + inch.y);

            _text.text = ($"{inch.x}:{inch.y}");
        }
    }
}
