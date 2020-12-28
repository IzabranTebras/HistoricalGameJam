using UnityEngine;

[CreateAssetMenu(menuName = "Installation")]
public class InstallationBase : ScriptableObject
{
    public string installationName = "New installation";
    public string description = "";
    public int buyCost = 0;
    public int maintainCost = 0;
    public InstallationEffectBase[] effects = null;

    public bool CheckResources()
    {
        //@TODO: Comprobar recursos y devolver true o false junto a un mensaje 
        return true;
    }

    public void CreateInstallation()
    {
        if (CheckResources())
        {
            //@TODO: Gastar los recursos necesarios
            ApplyEffects();
        }
    }

    private void ApplyEffects()
    {
        for(int i = 0; i < effects.Length; ++i)
        {
            effects[i].Apply();
        }
    }
}
