using UnityEngine;
using UnityEngine.UI;

///
public class ProfileListBehaviour : MonoBehaviour
{

    public Dropdown dropProfileList;
    void Start()
    {
        FillDrop.FillProfiles(ref dropProfileList, ProfileStatic.ProfilePath);
    }

}
