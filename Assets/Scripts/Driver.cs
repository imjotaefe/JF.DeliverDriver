using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] public float rotationSpeed = 0.05f;
    [SerializeField] public float moveSpeed = 0.01f;
    void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-rotationAmount);
        transform.Translate(0,speedAmount,0);
    }

}
