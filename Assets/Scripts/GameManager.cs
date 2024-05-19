using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI vehicleName;

    [SerializeField] private TextMeshProUGUI isElectric;

    [SerializeField] private Image vehicleImage;

    [SerializeField] private Image brandImage;

    [SerializeField] private Vehicles[] vehicles;

    private int onScreenVehicle;


    void Start()
    {
        ChangeVehicles();
    }

    public void ChangeVehicles()
    {
        if (vehicles[onScreenVehicle].isElectric)
        {
            isElectric.text = "Is electric? Yes";
        }

        else
        {
            isElectric.text = "Is Electric? No";
        }

        vehicleName.text = vehicles[onScreenVehicle].vehicleName;
        vehicleImage.sprite = vehicles[onScreenVehicle].vehicleImage;
        brandImage.sprite = vehicles[onScreenVehicle].brandImage;

    }

    public void previousVehicle()
    {

        if (onScreenVehicle == 0)
        {
            onScreenVehicle = vehicles.Length - 1;
        }

        else
        {
            onScreenVehicle--;
        }

        ChangeVehicles();

    }

    public void nextVehicle()
    {

        if (onScreenVehicle == vehicles.Length - 1)
        {
            onScreenVehicle = 0;
        }

        else
        {
            onScreenVehicle++;
        }

        ChangeVehicles();

    }

}
