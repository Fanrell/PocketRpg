using System.Collections;
using System.Collections.Generic;

public class ProfileModel : IEnumerable 
{
    private string profileName;
    public string ProfileName { get; set; }

    public IEnumerator GetEnumerator()
    {
        throw new System.NotImplementedException();
    }
}
