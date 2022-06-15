using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public List<GameObject> cars;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Co_WaitForSeconds());
    }

    private IEnumerator Co_WaitForSeconds()
    {
        while (true)
        {
            GameObject car = Instantiate(cars[Random.Range(0, cars.Count)],
            transform.position, Quaternion.identity);
            car.AddComponent<BoxCollider>().center = new Vector3(0, 0.5f, 0);
            car.GetComponent<BoxCollider>().size = new Vector3(1, 1, 5f);
            car.AddComponent<Rigidbody>();
            car.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            car.AddComponent<CarMoving>();
            car.tag = "car";
            car.transform.Rotate(new Vector3(0, transform.rotation.eulerAngles.y, 0), Space.World);
            car.transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            yield return new WaitForSeconds(Random.Range(8f, 10f));
        }
    }
}
