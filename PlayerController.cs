using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 300f; //calculator
    public float rotationRate = 7.5f; //mobil 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ComputerInput(){
        if(Input.GetKey("a")){
            transform.RotateAround(Vector3.zero, Vector3.forward, moveSpeed * Time.deltaTime);
        }
        if(Input.GetKey("d")){
            transform.RotateAround(Vector3.zero, Vector3.forward, -moveSpeed * Time.deltaTime);
        }
    }

    void MoblieInput(){
        foreach(Touch touch in Input.touches){
            if (touch.phase == TouchPhase.Moved){
                transform.RotateAround(Vector3.zero, Vector3.forward, -touch.deltaPosition.x * rotationRate / 10);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ComputerInput();
        MoblieInput();
    }

    void OntriggerEnter2D(Collider2D collision){
        SceneManager.LoadScene("SampleScene");
    }
}
