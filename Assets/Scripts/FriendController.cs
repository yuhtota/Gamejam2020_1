using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendController : MonoBehaviour
{
    public Text scoreText;
    public Text resultText;
    private Vector3 targetpos;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
        score = 0;
        SetCountText();
        resultText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * 7.5f + targetpos.x, targetpos.y, targetpos.z);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            score = score + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        scoreText.text = "Count: " + score.ToString();

        if (score >= 3)
        {
            resultText.text = "Thank You!";
        }
    }
}
