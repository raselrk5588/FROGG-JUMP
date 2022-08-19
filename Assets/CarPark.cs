using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPark : MonoBehaviour
{
    public float carCreateDely = 0.3f;
    public GameObject car;

    float nextTimeCreate = 0f;

    public Transform[] ParkPositions;

    // Update is called once per frame
    void Update()
    {
        if (nextTimeCreate <= Time.time)
        {
            CarCreate();

            nextTimeCreate = Time.time + carCreateDely;

        }
    }
    void CarCreate()
    {
        int CarParkIndex = Random.Range(0, ParkPositions.Length);
        Transform position = ParkPositions[CarParkIndex];
        Instantiate(car, position.position, position.rotation);
    }
}
