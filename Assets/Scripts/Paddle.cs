using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    //configuration params
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXValue = Input.mousePosition.x / Screen.width * screenWidthInUnits; //ne da valori intre 0 si 1
        Vector2 paddlePosition = new Vector2(mouseXValue, transform.position.y);
        paddlePosition.x = Mathf.Clamp(mouseXValue, minX, maxX); //Mathf.Clamp limiteaza paddlePositionX sa fie intre minX si maxX
        transform.position = paddlePosition;
    }
}
