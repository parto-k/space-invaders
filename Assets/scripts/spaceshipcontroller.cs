using UnityEngine;

public class spaceshipcontroller : MonoBehaviour
{
    public float moveSpeed=5;
    public float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalInput=Input.GetAxisRaw("Horizontal");
       transform.Translate(Vector2.right*moveSpeed*Time.deltaTime*horizontalInput); 
    }
}
