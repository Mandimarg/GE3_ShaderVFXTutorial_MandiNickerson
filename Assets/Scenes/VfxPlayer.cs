using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class VfxPlayer : MonoBehaviour
{
    public VisualEffect vfx_1;
    public VisualEffect vfx_2;

    public Transform vfxContainer_1;
    public Transform vfxContainer_2;

    VisualEffect instance_1;
    VisualEffect instance_2;

    void Start()
    {
        StartCoroutine(PlayVfx());
    }

    IEnumerator PlayVfx()
    {
        while (true)
        {
            if (instance_1 != null)
            {
                Destroy(instance_1);
            }
            if (instance_2 != null)
            {
                Destroy(instance_2);
            }

            instance_1 = Instantiate(vfx_1, vfxContainer_1);
            instance_2 = Instantiate(vfx_2, vfxContainer_2);

            instance_1.Play();
            instance_2.Play();

            yield return new WaitForSeconds(1);
        }
    }
}
