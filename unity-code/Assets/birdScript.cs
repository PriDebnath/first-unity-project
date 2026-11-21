// using UnityEngine;

// public class birdScript : MonoBehaviour
// {

//     public Rigidbody2D myRigidbody;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         gameObject.name ="Pri";
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if(Input.GetKeyDown(KeyCode.Space)==true){
//         //    if (Keyboard.current != null &&
//         //     Keyboard.current.spaceKey.wasPressedThisFrame){
   
//                     myRigidbody.linearVelocity = Vector2.up * 5;

//         };
//     }
// }
using UnityEngine;
using UnityEngine.InputSystem;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
public logicScript logic;
public bool alive = true;
    void Start()
    {
        gameObject.name = "Pri";
                logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<logicScript>();
    }

    void Update()
    {
        bool pressed =
        alive && (
            (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame) ||
            (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame) ||
            (Touchscreen.current != null && Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
            );

        if (pressed)
        {
            myRigidbody.linearVelocity = Vector2.up * 5;
        }
    }

       private void OnCollisionEnter2D(
        Collision2D collision
    ){
logic.gameOver();
alive = false;
    }
}