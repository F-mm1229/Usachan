using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PopUp : MonoBehaviour
{
    public Transform imageTransform;
    public Transform buttonTransform;

    // Start is called before the first frame update
    void Start()
    {
        imageTransform.DOScale(new Vector2(0f, 0f), 0f);
        buttonTransform.DOScale(new Vector2(0f, 0f), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PopOpen();
        }
    }

    public void PopOpen()
    {
        imageTransform.DOScale(new Vector2(1f, 1f), 0.5f)
                .SetEase(Ease.OutBack);
        buttonTransform.DOScale(new Vector2(1f, 1f), 0.5f)
                .SetEase(Ease.OutBack);
    }

    public void PopClose()
    {
        imageTransform.DOScale(new Vector2(0f, 0f), 0.5f)
                .SetEase(Ease.InQuart);
        buttonTransform.DOScale(new Vector2(0f, 0f), 0.5f)
                .SetEase(Ease.InQuart);
    }

}
