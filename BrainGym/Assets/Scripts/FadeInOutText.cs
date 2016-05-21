using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOutText : MonoBehaviour {
    public float FadeoutTime;
    private Color startColor;
    private float timer;   

	// Use this for initialization
	void Start ()
    {
        FadeoutTime = 1.0f;
        startColor = GetComponent<Text>().color;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer += FadeoutTime * Time.deltaTime;
        if (timer < 5.0f)
            GetComponent<Text>().color = Color.Lerp(startColor, Color.clear, FadeoutTime * Time.deltaTime);
        else
        {
            timer = 0.0f;
            GetComponent<Text>().color = Color.Lerp( Color.clear, startColor, FadeoutTime * Time.deltaTime);
        }
    }
}
