using UnityEngine;

public class moveSphere : MonoBehaviour
{
	public float speed = 2f;
	
    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;
        
        if(Input.GetKey(KeyCode.A)){
        	horizontal = -1;
        }if(Input.GetKey(KeyCode.D)){
        	horizontal = 1;
        }if(Input.GetKey(KeyCode.W)){
        	vertical = 1;
        }if(Input.GetKey(KeyCode.S)){
        	vertical = -1;
        }
        //ex9
	//transform.Translate(horizontal * speed, vertical * speed, 0);
	
	//ex10
        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
    }
}
