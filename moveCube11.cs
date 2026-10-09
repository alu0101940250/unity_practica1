using UnityEngine;

public class moveCube11 : MonoBehaviour
{
	public Transform sphere;
	public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = sphere.position - transform.position;
        direction.y = 0;
        
        float stepThisFrame = speed * Time.deltaTime;
        if(direction.magnitude > stepThisFrame){
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime);}
    }
}
