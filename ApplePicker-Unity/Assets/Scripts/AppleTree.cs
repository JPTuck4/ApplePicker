/***
 * Created by: JP Tucker
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 10, 2022
 * 
 * Description: Controls the movement of the Apple Tree
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("SET IN INSPECTOR")]
    public float speed = 1f; //tree speed
    public float leftAndRightEdge = 10f; //distance where tree turns
    public GameObject applePrefab; //prefab for instantiating apples
    public float appleRate = 1f; // time in seconds between apples
    public float chanceToChangeDirections = 0.1f; //chance the tree changes direction

    // Start is called before the first frame update
    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab); // instantiates prefab
        apple.transform.position = transform.position; // sets position to tree position
        Invoke("DropApple", appleRate); // calls dropApple again 1 second later
    }


    // Update is called once per frame
    void Update()
    {
        //Basic Movement
        Vector3 pos = transform.position; //records current position
        pos.x += speed * Time.deltaTime; //updates new position
        transform.position = pos; //apply position value

        //Change Direction
        if (pos.x < -leftAndRightEdge || pos.x > leftAndRightEdge)
            speed *= -1; //switch directions
        
    }

    //FixedUpdate called on fixed intervals (50 times per second)
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
            speed *= -1; //change directions
    }
}
