using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMov : MonoBehaviour
{
    // Player Speed
    private float speed = 3;
    private static float numbX = 0;
    private static float numbZ = 0;
    private float translationX;
    private float translationZ;
    
    public static float numbX1
    {
        get => numbX;
        set => numbX = value;
    }

    public static float numbZ1
    {
        get => numbZ;
        set => numbZ = value;
    }

    private void Update()
    {
        translationX = numbX * speed; 
        translationX *= Time.deltaTime;
        
        translationZ = numbZ * speed; 
        translationZ *= Time.deltaTime;

        transform.Translate(0, 0, translationZ);
        
        transform.Translate(translationX, 0, 0);
        
    }
}
