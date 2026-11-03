using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public TextMeshProUGUI GrassText;
    public PlayerBehaviour Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.TouchingGrass)
        {
            GrassText.text = "is touching grass";
        }
        else
        {
            GrassText.text = "not touching grass";
        }
    }
}
