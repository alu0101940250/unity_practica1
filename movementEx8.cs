using UnityEngine;

public class movementEx8 : MonoBehaviour
{
	public Vector3 moveDirection;
	public float speed = 2f;
	
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveDirection.x * speed, moveDirection.y * speed, moveDirection.z * speed);
        //transform.Translate(moveDirection.x * speed, moveDirection.y * speed, moveDirection.z * speed, Space.Self);
        transform.Translate(moveDirection.x * speed, moveDirection.y * speed, moveDirection.z * speed, Space.World);
    }
}
