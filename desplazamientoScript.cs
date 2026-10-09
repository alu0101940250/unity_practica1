using UnityEngine;

public class desplazamientoScript : MonoBehaviour
{
	private Vector3 originalPos;
	public Vector3 desplazamiento;
	
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        originalPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Jump") > 0){
        	transform.position = originalPos + desplazamiento;
        }
    }
}
