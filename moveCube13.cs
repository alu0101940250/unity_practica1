using UnityEngine;

public class moveCube13 : MonoBehaviour
{
 	public float speed = 2f;
 	public float rotation = 50f;
 	
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, rotation * horizontal * Time.deltaTime, 0);
        transform.position += transform.forward * speed * Time.deltaTime;
        Debug.DrawRay(transform.position, transform.forward * 5f, Color.blue);
    }
}
