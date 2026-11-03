using UnityEngine;

public class SurvivalMod : MonoBehaviour
{
    public string playerName = "Niklas";
    
    public int health = 3;
    
    public float stamina = 100f;
    public float staminaDrainRate;

    public bool tired;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hi my name is: " + playerName);
    }

    // Update is called once per frame
    void Update()
    {
        stamina -= staminaDrainRate*Time.deltaTime;

        if (stamina <= 50f)
        {
            tired = true;
        }
    }
}
