using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject hitCircleObject;

    public Camera fpsCam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("ok");
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform);

            GameObject hitCircle = Instantiate(hitCircleObject, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(hitCircle, 5f);
        }
    }
}

    