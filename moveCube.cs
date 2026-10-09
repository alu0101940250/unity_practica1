using UnityEngine;

public class moveCube : MonoBehaviour
{
	public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0;
        float vertical = 0;
        
        if(Input.GetKey(KeyCode.LeftArrow)){
        	horizontal = -1;
        }if(Input.GetKey(KeyCode.RightArrow)){
        	horizontal = 1;
        }if(Input.GetKey(KeyCode.UpArrow)){
        	vertical = 1;
        }if(Input.GetKey(KeyCode.DownArrow)){
        	vertical = -1;
        }
        //ex9
        //transform.Translate(horizontal * speed, vertical * speed, 0);
        
        //ex10
        transform.Translate(horizontal * speed * Time.deltaTime, vertical * speed * Time.deltaTime, 0);
    }
}
