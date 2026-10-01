using UnityEngine;

public class calculations : MonoBehaviour
{

	public Vector3 vector1;
	public Vector3 vector2;
	
	public float magnitude1;
	public float magnitude2;
	public float angle;
	public float distance;
	public string higherVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    	magnitude1 = vector1.magnitude;
    	magnitude2 = vector2.magnitude;
    	
    	angle = Vector3.Angle(vector1, vector2);
    	distance = Vector3.Distance(vector1, vector2);
    	
    	if(vector1.y > vector2.y){
    		higherVector = "El vector 1 es más alto";}
    	else if(vector1.y < vector2.y){
    		higherVector = "El vector 2 es más alto";}
    	else{
    		higherVector = "Los vectores tienen la misma altura";}
        
        Debug.Log("La magnitud del vector 1: " + magnitude1);
        Debug.Log("La magnitud del vector 2: " + magnitude2);
        Debug.Log("El ángulo que forman: " + angle);
        Debug.Log("La distancia entre ambos.: " + distance);
        Debug.Log("Vector qué está a una altura mayor: " + higherVector);
    }
}
