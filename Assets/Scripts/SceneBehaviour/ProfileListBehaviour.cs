using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class ProfileListBehaviour : MonoBehaviour
{
    public Dropdown dropProfileList;
    // Start is called before the first frame update
    void Start()
    {
        string tmp = "";
        //File.Delete(ProfileFilePath.ProfilePath + "profile.prof");
        using(StreamReader reader = new StreamReader(ProfileFilePath.ProfilePath + "profile.prof"))
        {
            while(!reader.EndOfStream)
            {
                dropProfileList.options.Add(new Dropdown.OptionData { text = reader.ReadLine() });
            }
        }
    }

}
