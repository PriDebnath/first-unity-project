
// using UnityEngine;

// public class animationScript : MonoBehaviour
// {
//     public Sprite[] frames;
//     public float frameRate = 0.2f;

//     private SpriteRenderer spriteRenderer;
//     private int currentFrame = 0;
//     private float timer = 0f;

//     void Start()
//     {
//         spriteRenderer = GetComponent<SpriteRenderer>();

//         // Show first frame
//         spriteRenderer.sprite = frames[0];
//     }

//     void Update()
//     {
//         timer += Time.deltaTime;

//         if (timer >= frameRate)
//         {
//             timer = 0f;

//             currentFrame++;

//             if (currentFrame >= frames.Length)
//             {
//                 currentFrame = 0;
//             }

//             spriteRenderer.sprite = frames[currentFrame];
//         }
//     }
// }
