/***
 * Created by: JP Tucker
 * Date Created: Jan 31, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 7, 2022
 * 
 * Description: Controls the movement of the Baskets
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header('Set Dynamically')]
    public Text scoreGT;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");//score game object
        scoreGT = scoreGO.GetComponent<Text>();//text component
        scoreGT.text = "0";//set text property to 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    GameObject collideWith = collideWith.gameObject
    //    if(collideWith.tag == "Apple")
    //    {
    //        Destroy(collideWith);

    //        int score = int.Parse(scoreGT.text);
    //        score += 100;
    //        scoreGT.text = score.ToString();
    //    }
    //}
}
