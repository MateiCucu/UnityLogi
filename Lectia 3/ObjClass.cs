using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjClass : MonoBehaviour
{
    public static ObjClass Instance {get; set;}
    // Start is called before the first frame update
    private voide Awake()
    {
        Instance = this;
    }

    public Queue Get()
    {
        obstacle.gameObject..setActive(false);
        Items.Enqueue(obstacle);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
