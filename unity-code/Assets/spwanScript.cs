using UnityEngine;

public class spwanPipeScript : MonoBehaviour
{
    public GameObject pipe;
    public float spwanRate = 2;
    private float timer = 0;
    public float heightOffset = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()  {
                    instantiatePipe ();
    }

    // Update is called once per frame
    void Update()  {
        if(timer < spwanRate ){
            timer =  timer + Time.deltaTime;
        }else{
            instantiatePipe();
            timer = 0;
        }
    }


   void instantiatePipe(){
    float low = transform.position.y - heightOffset;
    float high = transform.position.y + heightOffset;
            Instantiate(
                pipe,
                 new Vector3(transform.position.x,Random.Range(low, high) , 0), 
                 transform.rotation
                 );
    }
}
