using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PlateformRotaion : MonoBehaviour
{
    public float degrees = 20;
    public GameObject PlateformToSpin;

    void Start()
    {
       
    }
    private void Update()
    {
        PlateformToSpin.transform.Rotate(new Vector3(0, 0, degrees) * Time.deltaTime);
    }


}
