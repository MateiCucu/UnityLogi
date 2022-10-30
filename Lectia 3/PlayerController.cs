using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float screenWidth;
	private float speed = 8f;
	private float prevSpeed;

    // Start is called before the first frame update
    void Start()
    {
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        //Computer controls
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -1.5f)
            transform.position += Vector3.left * 1f;

        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 1.5f)
            transform.position += Vector3.right * 1f;


        //Mobile controls
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).position.x < screenWidth / 2f && Input.GetTouch(i).phase == TouchPhase.Ended && transform.position.x > -1.5f)
                transform.position -= Vector3.right * 1f;
            if (Input.GetTouch(i).position.x > screenWidth / 2f && Input.GetTouch(i).phase == TouchPhase.Ended && transform.position.x < 1.5f)
                transform.position += Vector3.right * 1f;
        }
    }
	
	private void OnTriggerEnter (Collider other)
	{
		if (other.GetComponentInChildren<Transform>().tag == "obstacol")
		{
			Destroy(other.gameObject);
			
			if (GetComponent<Renderer>().material.color != other.GetComponent<Renderer>().material.color)
			{
				prevSpeed = speed;
				speed += 0.5f;
				
			}
		}
	}
}
