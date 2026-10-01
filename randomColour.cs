using UnityEngine;

public class randomColour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public int frames = 120;
    private int frameCnt = 0;
    private Vector3 vector;
    private Renderer renderer;
    
    void Start()
    {
        renderer = GetComponent<Renderer>();
        
        vector = new Vector3(
        	Random.value,
        	Random.value,
        	Random.value);
        	
	Color newColor = new Color(
		vector.x,
		vector.y,
		vector.z);
		
	renderer.material.color = newColor;
    }

    // Update is called once per frame
    void Update()
    {
        frameCnt++;
        
        if(frameCnt >= frames){
        	frameCnt = 0;
        	int random = Random.Range(0, 3);
        	
        	if(random == 0){
        		vector.x = Random.value;
        	}
        	else if(random == 1){
        		vector.y = Random.value;
        	}
        	else{
        		vector.z = Random.value;
        	}
        	
        Color newColor = new Color(
		vector.x,
		vector.y,
		vector.z);
		
	renderer.material.color = newColor;
        }
    }
}
