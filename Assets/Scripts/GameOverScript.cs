using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameOverScript : MonoBehaviour
{
    public TMP_Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score.text= PlayerPrefs.GetString("score");


    }

    // Update is called once per frame
  
}
