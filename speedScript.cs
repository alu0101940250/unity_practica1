using UnityEngine;

public class speedScript : MonoBehaviour
{
	public float speed;

// Update is called once per frame
    void Update()
    {
	float horizontal = Input.GetAxis("Horizontal");
	float vertical = Input.GetAxis("Vertical");

	if(Input.GetKey(KeyCode.LeftArrow)){
		Debug.Log("Left Arrow " + speed * horizontal);
	}if(Input.GetKey(KeyCode.RightArrow)){
		Debug.Log("Right arrow " + speed * horizontal);
	}if(Input.GetKey(KeyCode.UpArrow)){
		Debug.Log("Up arrow " + speed * vertical);
	}if(Input.GetKey(KeyCode.DownArrow)){
		Debug.Log("Down arrow " + speed * vertical);
	}
    }
}
