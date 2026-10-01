using UnityEngine;

public class position : MonoBehaviour
{
	public Vector3 positionSphere;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        positionSphere = transform.position;
        
        Debug.Log("La posición de la esfera es:" + positionSphere);
    }
}
