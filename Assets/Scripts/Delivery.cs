using System;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 noColorPackage = new Color32(1,1,1,1);
    bool hasPackage;
    SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collide");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Package") && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Picked Up the Package");
            _spriteRenderer.color = col.GetComponent<SpriteRenderer>().color;
            Destroy(col.gameObject);
        }

        if (col.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered");
            _spriteRenderer.color = noColorPackage;
            hasPackage = false;
        }
    }
}
