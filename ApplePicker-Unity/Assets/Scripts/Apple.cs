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

public class Apple : MonoBehaviour
{
    [Header("Set in Inspector")]
    public static float bottomY = -20f; //despawn apples

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject); //remove apples
            GameObject gm = GameObject.Find("GameManager");
            ApplePicker apScript = gm.GetComponent<ApplePicker>();
            apScript.AppleDestroyed();
        }
    }
}
