using UnityEngine;
using TMPro;
public class pointManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;
public TMP_Text scoreText;
    void Start()
    {
      scoreText.text="Score: "+score;  
    }

    // Update is called once per frame
   public void UpdateScore(int points){
   
    score+=points;
 Debug.Log("Score updated to: " + score);
    scoreText.text="Score: "+score;

   }
}
