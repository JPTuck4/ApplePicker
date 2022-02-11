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
using UnityEngine.UI; // Remember, we need this line for uGUI to work.
public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    void Awake()
    {
      // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        PlayerPrefs.SetInt("HighScore", score); // c
    }


    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        //update playerprefs
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
