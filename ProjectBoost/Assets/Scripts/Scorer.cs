using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    int intScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText.text = intScore.ToString();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectible")
        {
            Destroy(other.gameObject);
            intScore++;
            scoreText.text = intScore.ToString();
        }
    }
}
