using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightScore : MonoBehaviour
{

    private int lightCount = 0;
    private Text score;
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("UIScore").GetComponent<Text>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag.Equals("Light"))
        {
            lightCount++;
            Destroy(collider.gameObject);
            score.text = "" + lightCount;
        }

        if (collider.tag.Equals("Final"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
