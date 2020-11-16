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
        Debug.Log(ProfileFilePath._profilePath);
        if (File.Exists(ProfileFilePath._profilePath))
        {
            using (StreamReader reader = new StreamReader(ProfileFilePath._profilePath))
            {
                while (!reader.EndOfStream)
                {
                    dropProfileList.options.Add(new Dropdown.OptionData { text = reader.ReadLine() });
                }
            }
        }
    }

}
