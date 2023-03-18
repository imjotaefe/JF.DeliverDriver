using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followThing;

    void LateUpdate()
    {
        transform.position = followThing.transform.position + new Vector3(0,0,-10);
    }
}
