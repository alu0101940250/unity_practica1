using UnityEngine;

public class distance : MonoBehaviour
{
	public float distanceCube;
	public float distanceCylinder;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    	GameObject cube = GameObject.FindWithTag("Cube");
    	GameObject cylinder = GameObject.FindWithTag("Cylinder");
        
	distanceCube = Vector3.Distance(
	transform.position,
	cube.transform.position);
	
	distanceCylinder = Vector3.Distance(
	transform.position,
	cylinder.transform.position);
	
	Debug.Log("Distancia esfera cubo: " + distanceCube);
        Debug.Log("Distancia esfera cilindro: " + distanceCylinder);
    }
}
