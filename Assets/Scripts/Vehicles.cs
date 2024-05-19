using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "ScriptableObject/Vehicles")]
public class Vehicles : ScriptableObject
{

    public string vehicleName;
    public Sprite vehicleImage;
    public Sprite brandImage;
    public bool isElectric;

}
