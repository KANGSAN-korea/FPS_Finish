using System.Collections;
using UnityEngine;

public class ItemMagazine : ItemBase
{
    [SerializeField]
    private GameObject magazineEffectPrefab;
    [SerializeField]
    private int increaseMagazine = 2;
    [SerializeField]
    private float rotateSpeed = 50;

    private IEnumerator Start()
    {
        while (true)
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

            yield return null;
        }
    }

    public override void Use(GameObject entity)
    {
        //entity.GetComponentInChildren<WeaponAssaultRifle>().IncreaseMagazine(increaseMagazine);
        entity.GetComponent<WeaponSwitchSystem>().IncreaseMagazine(WeaponType.Main, increaseMagazine);
        Instantiate(magazineEffectPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
