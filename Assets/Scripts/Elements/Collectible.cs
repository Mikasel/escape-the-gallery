using DG.Tweening;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartAnimation();
    }

    private void StartAnimation()
    {
        transform.DOMoveY(transform.position.y + 0.4f, 0.5f)
            .SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutQuad);
        transform.DORotate(Vector2.up * 90,  0.5f)
            .SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
