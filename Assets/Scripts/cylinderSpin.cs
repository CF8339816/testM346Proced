using UnityEngine;



public class cylinderSpin : MonoBehaviour

{


    [Header("Rotate Cylinder Settings")]

    // deefine rotation for cube

    public Vector3 RotationSpeed = new Vector3(25f, 150f, 75f);

    //// Start is called once before the first execution of Update after the MonoBehaviour is created

    //void Start()

    //{

    //}

    // Update is called once per frame

    void Update()

    {

        transform.Rotate(RotationSpeed * Time.deltaTime);

    }

}
