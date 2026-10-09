using UnityEngine;

public class moveCube11 : MonoBehaviour
{
	public Transform sphere;
	public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(
        sphere.position.x,
        transform.position.y,
        sphere.position.z);
        
        transform.LookAt(direction);
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
