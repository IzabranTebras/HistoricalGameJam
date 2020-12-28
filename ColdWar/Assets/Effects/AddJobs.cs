using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effect/AddJobs")]
public class AddJobs : InstallationEffectBase
{
    public int newJobs = 1;

    public override void Apply()
    {
        //@TODO: Aqui hay que crear los puestos de trabajo necesarios. Esto tendrá que hacerse cuando tengamos la base hecha
    }
}
